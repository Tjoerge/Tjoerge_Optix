#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Alarm;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.Recipe;
using FTOptix.WebUI;
using FTOptix.DataLogger;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.EthernetIP;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.CommunicationDriver;
using FTOptix.NetLogic;
using FTOptix.Core;
using System.Security.Claims;
#endregion

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void Create_Folder_Tags()
    {
        var myFolder = Project.Current.Get<Folder>("Model/CSharp_Created");
        if (myFolder!= null)
        {
            myFolder.Delete();
        }
        myFolder = InformationModel.Make<Folder>("CSharp_Created");
        Project.Current.Get("Model").Add(myFolder); 
        for (int i = 0; i < 5; i++)
        {
            var myvar = InformationModel.MakeVariable("Variabel " + i, OpcUa.DataTypes.UInt32);
            myFolder.Add(myvar);
        }


    }
}
