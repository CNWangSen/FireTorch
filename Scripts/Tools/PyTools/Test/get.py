'''
import os

for f in os.listdir("D:/Projects/GameHackProj/HackFY/FYJY/"):
	#s="Assembly.Load(System.IO.File.ReadAllBytes("+'"'+"D:/Projects/unitybuild/FixAssem/"+f+'"'+"));"
	print(f)
'''
# encoding:utf-8
# Copyright (C) 2021-2024 Liu Qinghao
__author__ = 'Liu Qinghao'
 
import wmi   # 硬件信息
import uuid  # 网卡MAC地址用
 
class GetHardwareInformation:
    '''
    获取当前电脑 self.硬件信息,包括:
    主板序列号   get_board_id
    bios序列号   get_bios_id
    CPU序列号    get_cpu_id
    硬盘序列号   get_physical_disk_id
    所有网卡地址 get_all_mac
    其中无线地址 get_MACAddress
    其中有线地址 get_pc_mac_address (不准确)
    获得所有硬件信息 get_all
    所有返回信息中的英文均大写
    '''
    def __init__(self) -> None:
        self.硬件信息 = wmi.WMI()
 
    def get_all_mac(self):
        # mac地址
        result=''
        for mac in self.硬件信息.Win32_NetworkAdapter():
            if mac.MACAddress is not  None:
                result += mac.MACAddress+' '
        return result.strip().upper()
 
    def get_MACAddress(self):
        '''
        获取无线网络MAC地址 返回大写地址,如:A8-8A-D2-7D-03-CD
        '''
        MACAddress = ''
        for nw in self.硬件信息.Win32_NetworkAdapterConfiguration(IPEnabled=1):
            MACAddress += nw.MACAddress +' '
        return MACAddress.strip().upper()
 
    def get_pc_mac_address(self):
        """
        获取PC的Mac地址,返回大写地址,如:F8-A2-D6-CC-BB-AA
        """
        mac = uuid.UUID(int=uuid.getnode()).hex[-12:]
        MACAddress = ":".join([mac[e:e + 2] for e in range(0, 11, 2)]).upper()
        return MACAddress
 
    def get_physical_disk_id(self):
        # # 硬盘序列号 
        result=''
        for physical_disk in self.硬件信息.Win32_DiskDrive():
            result += physical_disk.SerialNumber+' '
        return result.strip().upper()
 
    def get_cpu_id(self):
        # CPU序列号 获取费时间
        result=''
        for cpu in self.硬件信息.Win32_Processor():
            result += cpu.ProcessorId.strip()+' '
        return result.strip().upper()
 
    def get_board_id(self):
        # 主板序列号 获取速度快
        result=''
        for board_id in self.硬件信息.Win32_BaseBoard():
            result += board_id.SerialNumber+' '
        return result.strip().upper()
 
    def get_bios_id(self):
        # bios序列号 获取速度快
        result=''
        for bios_id in self.硬件信息.Win32_BIOS():
            result += bios_id.SerialNumber+' '
        return result.strip().upper()
 
    def get_all(self):
        # 列出所有硬件信息
        result=(f'主板序列号:{self.get_board_id()}\nbios序列号:{self.get_bios_id()}\nCPU序列号:{self.get_cpu_id()}\n硬盘序列号:{self.get_physical_disk_id()}\n所有网卡网址:{self.get_all_mac()}\n其中无线网址:{self.get_MACAddress()}\n其中有线网址:{self.get_pc_mac_address()}')
        print (result)
        return result
 
if __name__ == '__main__':
    a=GetHardwareInformation().get_all()