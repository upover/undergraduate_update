﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoCalibrationSystem.DataAccess;
using System.Windows.Forms;
/*
 *分压器测量过程
 * 
 * 
 */
namespace AutoCalibrationSystem
{
    public class DividerProcess
    {
        public EnumMode curMode;        //当前模式
        public EnumMode initiMode = EnumMode.Divider_V_DCP;      //连续测量时初始测量模式
        public int curNum;              //当前测量点序号
        public int curModeTotal;        //当前模式总点数
        public int curNumTest;          //当前待测分压器测量点数
        public int curNumStand;         //当前标准分压器测量点数
        public int curNumTandH;         //当前温湿度模块测量点数
        public EnumCaliState complete;  //测量状态
        public int curTotalNum;         //当前已测量的总点数
        public int totalNum;            //需要测量的总点数 
        public bool changeMode;         //是否需要切换模式
        public bool modeSaveData;       //是否自动保存数据
        public bool modeMeasType;       //测量种类：true所有，false当前
        public bool modeCycleSwitch;    //是否循环测量
        public float curSource;         //当前测量的输入源
        public DividerProcess() {
           
        }
        public DividerProcess(EnumMode mode, DividerData dividerData)
        {
            ResetProcess(mode,dividerData);
        }

        public void ResetProcess(EnumMode mode, DividerData dividerData)
        {
            this.curNum = -1;
            this.curNumTest = -1;
            this.complete = EnumCaliState.INITI;
            this.curTotalNum = 0;
            this.curMode = mode;           
            setTotalNumByType(dividerData);
        }
        public void setTotalNumByType(DividerData dividerData) 
        {
            int total = 0;
            switch (this.curMode)
            {
                case EnumMode.Divider_V_DCP:
                    curModeTotal = dividerData.voltageDCPData.Count;
                    total = dividerData.voltageDCPData.Count + dividerData.voltageDCNData.Count + dividerData.voltageACData.Count
                            + dividerData.frequencyData.Count;
                    break;
                case EnumMode.Divider_V_DCN:
                    curModeTotal = dividerData.voltageDCNData.Count;
                    total = dividerData.voltageDCNData.Count + dividerData.voltageACData.Count
                            + dividerData.frequencyData.Count;
                    break;
                case EnumMode.Divider_V_AC:
                    curModeTotal = dividerData.voltageACData.Count;
                    total = dividerData.voltageACData.Count + dividerData.frequencyData.Count;
                    break;
                case EnumMode.Divider_F:
                    curModeTotal = dividerData.frequencyData.Count;
                    total = dividerData.frequencyData.Count;
                    break;
            }
            //当前模式和初始模式相同时，设置总数量
            if (curMode == initiMode)
            {
                //方式是全部监测
                if (this.modeMeasType)
                {
                    this.totalNum = total;
                }
                //方式是当前模式监测
                else
                {
                    this.totalNum = this.curModeTotal;
                }
            }
        }
        //保存数据到数据库
        private void SaveDividerDataToSql(DividerData dividerData)
        {
            bool result = false;
            //判断测量种类
            if (this.modeMeasType)
            {
                //全部
                result = DAO.SaveDividerDataAll(dividerData);
            }
            else
            {
                //当前，保存当前测量项的数据
                result = DAO.SaveDividerDataByMode(dividerData, this.initiMode);
            }
            if (result)
                MessageBox.Show("保存数据成功");
            else
                MessageBox.Show("保存数据出错");
        }
        //获取模式
        public void getCurMode(DividerData dividerData,bool dataValid)
        {
            changeMode = false;
            //当前模式校准完成，curNum从-1开始
            if (curNum == curModeTotal-1)
            {
                if (!modeCycleSwitch)
                {
                    //循环开关关闭
                    if (modeMeasType == false)
                    {
                        //测试模式是当前模式
                        //数据读取完整
                        if (dataValid)
                        {
                            //测试完成
                            this.complete = EnumCaliState.COMPLETE;
                            //自动保存数据
                            if (this.modeSaveData)
                            {
                                SaveDividerDataToSql(dividerData);
                            } 
                        }
                        return;
                    }
                    else 
                    {
                        //测试模式是所有模式，根据当前模式进入到下一模式
                        switch (curMode)
                        {
                            case EnumMode.Divider_V_DCP:
                                curMode = EnumMode.Divider_V_DCN;
                                break;
                            case EnumMode.Divider_V_DCN:
                                curMode = EnumMode.Divider_V_AC;
                                break;
                            case EnumMode.Divider_V_AC:
                                curMode = EnumMode.Divider_F;
                                break;
                            case EnumMode.Divider_F:
                                this.complete = EnumCaliState.COMPLETE;
                                return;
                        }
                    }

                }
                else 
                {
                    //循环开关打开时
                    //循环测量时，默认自动保存数据
                    DAO.SaveDividerDataByMode(dividerData, curMode);
                    dividerData.Reset(false, curMode);
                    if (modeMeasType)
                    {
                        //测试模式是所有模式时，根据当前模式进入到下一模式
                        switch (curMode)
                        {
                            case EnumMode.Divider_V_DCP:
                                curMode = EnumMode.Divider_V_DCN;
                                break;
                            case EnumMode.Divider_V_DCN:
                                curMode = EnumMode.Divider_V_AC;
                                break;
                            case EnumMode.Divider_V_AC:
                                curMode = EnumMode.Divider_F;
                                break;
                            case EnumMode.Divider_F:
                                curMode = EnumMode.Divider_V_DCP;
                                break;
                        }
                    }
                    else
                    {
                        //测试模式是当前模式时，直接重置此模式        
                    }
                    ResetProcess(curMode, dividerData); 
                }

            }
        }
    }
}
