﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Goibibo_Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GIBUS recording.
    /// </summary>
    [TestModule("982f458c-fdfd-4c31-9fe4-7fa7120b78ff", ModuleType.Recording, 1)]
    public partial class GIBUS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IF repository.
        /// </summary>
        public static IF repo = IF.Instance;

        static GIBUS instance = new GIBUS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GIBUS()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GIBUS Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5' at 4;15.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5Info, new RecordItemIndex(0));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5.Click("4;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.GiSource' at 120;21.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiSourceInfo, new RecordItemIndex(1));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiSource.Click("120;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Delhi' with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.GiSource'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiSourceInfo, new RecordItemIndex(2));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiSource.PressKeys("Delhi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MainTxt1' at 110;2.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MainTxt1Info, new RecordItemIndex(3));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MainTxt1.Click("110;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.GiDestination' at 87;35.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiDestinationInfo, new RecordItemIndex(4));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiDestination.Click("87;35");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Agra' with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.GiDestination'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiDestinationInfo, new RecordItemIndex(5));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiDestination.PressKeys("Agra");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Current' at 91;6.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.CurrentInfo, new RecordItemIndex(6));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Current.Click("91;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.GiOnwardText' at 106;23.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiOnwardTextInfo, new RecordItemIndex(7));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiOnwardText.Click("106;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.SpanTag22' at 1;3.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.SpanTag22Info, new RecordItemIndex(8));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.SpanTag22.Click("1;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.GiSearchBtn' at 51;27.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiSearchBtnInfo, new RecordItemIndex(9));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GiSearchBtn.Click("51;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(10));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(11));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Time' at 6;4.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.TimeInfo, new RecordItemIndex(12));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Time.Click("6;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.BoardingPoint' at 63;11.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.BoardingPointInfo, new RecordItemIndex(13));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.BoardingPoint.Click("63;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(14));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1080 units.", new RecordItemIndex(15));
            Mouse.ScrollWheel(1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.DroppingPoint' at 7;1.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.DroppingPointInfo, new RecordItemIndex(16));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.DroppingPoint.Click("7;1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.BusOperators' at 81;16.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.BusOperatorsInfo, new RecordItemIndex(17));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.BusOperators.Click("81;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.ATagCp' at 30;10.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.ATagCpInfo, new RecordItemIndex(18));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.ATagCp.Click("30;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FtBookbtn' at 55;18.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FtBookbtnInfo, new RecordItemIndex(19));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FtBookbtn.Click("55;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.OnwRedbusnewAt200001192974000153034' at 7;6.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.OnwRedbusnewAt200001192974000153034Info, new RecordItemIndex(21));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.OnwRedbusnewAt200001192974000153034.Click("7;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '25288-Sagar Pur' on item 'Hotel.OnlineFlightBookingHotelsBusAmp.BpOnwRedbusnewAt2000011929740001530'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.BpOnwRedbusnewAt2000011929740001530Info, new RecordItemIndex(22));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.BpOnwRedbusnewAt2000011929740001530.Element.SetAttributeValue("TagValue", "25288-Sagar Pur");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Confirm' at 28;11.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.ConfirmInfo, new RecordItemIndex(23));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Confirm.Click("28;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(24));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(25));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.CancellationPolicy' at 60;3.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.CancellationPolicyInfo, new RecordItemIndex(26));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.CancellationPolicy.Click("60;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0' at 3;2.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0Info, new RecordItemIndex(27));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0.Click("3;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(28));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item 'Hotel.OnlineFlightBookingHotelsBusAmp.Adultchoose1'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.Adultchoose1Info, new RecordItemIndex(29));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Adultchoose1.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Adultfirstname1' at 51;16.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.Adultfirstname1Info, new RecordItemIndex(30));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Adultfirstname1.Click("51;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Devendra{Tab}Gupta{Tab}22' with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.Adultfirstname1'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.Adultfirstname1Info, new RecordItemIndex(31));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Adultfirstname1.PressKeys("Devendra{Tab}Gupta{Tab}22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Email' at 191;17.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.EmailInfo, new RecordItemIndex(32));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Email.Click("191;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Back}testnoc009{LShiftKey down}{@ down}{LShiftKey up}gmail.com' with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.Email'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.EmailInfo, new RecordItemIndex(33));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Email.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}testnoc009{LShiftKey down}{@ down}{LShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Mobile' at 154;22.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MobileInfo, new RecordItemIndex(34));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Mobile.Click("154;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.Mobile'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MobileInfo, new RecordItemIndex(35));
            Keyboard.PrepareFocus(repo.Hotel.OnlineFlightBookingHotelsBusAmp.Mobile);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}9999999999' with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.Mobile'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MobileInfo, new RecordItemIndex(36));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Mobile.PressKeys("{Back}9999999999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.SpanTagFareBreakup' at 5;4.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.SpanTagFareBreakupInfo, new RecordItemIndex(37));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.SpanTagFareBreakup.Click("5;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid01' at 8;6.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid01Info, new RecordItemIndex(38));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid01.Click("8;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FIRSTBUS' at 10;8.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FIRSTBUSInfo, new RecordItemIndex(39));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FIRSTBUS.Click("10;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0' at 8;6.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0Info, new RecordItemIndex(40));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0.Click("8;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Get10PercentUptoRs50Off' at 45;11.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.Get10PercentUptoRs50OffInfo, new RecordItemIndex(41));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Get10PercentUptoRs50Off.Click("45;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0' at 10;7.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0Info, new RecordItemIndex(42));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0.Click("10;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MakePayment' at 244;6.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MakePaymentInfo, new RecordItemIndex(43));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MakePayment.Click("244;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(44));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(45));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(46));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(47));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(48));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(49));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(50));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.IconInfoDibIco14GreyDrMarginL10VMi' at 1;3.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.IconInfoDibIco14GreyDrMarginL10VMiInfo, new RecordItemIndex(51));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.IconInfoDibIco14GreyDrMarginL10VMi.Click("1;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0' at 4;7.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0Info, new RecordItemIndex(52));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0.Click("4;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(53));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.TabnavOpts.NetBanking' at 43;16.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.TabnavOpts.NetBankingInfo, new RecordItemIndex(54));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.TabnavOpts.NetBanking.Click("43;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.PayNetbRb' at 4;5.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.PayNetbRbInfo, new RecordItemIndex(55));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.PayNetbRb.Click("4;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Submit' at 178;25.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.SubmitInfo, new RecordItemIndex(56));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Submit.Click("178;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(57));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.StateBankOfIndiaInternetBanking.ClickHere' at 19;6.", repo.Hotel.StateBankOfIndiaInternetBanking.ClickHereInfo, new RecordItemIndex(58));
            repo.Hotel.StateBankOfIndiaInternetBanking.ClickHere.Click("19;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma' at 58;13.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideImaInfo, new RecordItemIndex(59));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma.Click("58;13");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
