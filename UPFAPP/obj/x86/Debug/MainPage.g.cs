﻿#pragma checksum "C:\Users\kande\OneDrive\Desktop\client server\UPFAPP\UPFAPP\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CE028707B671C644349980FFC26A4871CC655C8B8E55A757018563DC2F6047B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPFAPP
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.add).Click += this.add_Click;
                }
                break;
            case 3: // MainPage.xaml line 13
                {
                    this.sub = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.sub).Click += this.sub_Click;
                }
                break;
            case 4: // MainPage.xaml line 14
                {
                    this.mul = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.mul).Click += this.mul_Click;
                }
                break;
            case 5: // MainPage.xaml line 15
                {
                    this.fNum = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // MainPage.xaml line 16
                {
                    this.sNum = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 17
                {
                    this.Num1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // MainPage.xaml line 18
                {
                    this.Num2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // MainPage.xaml line 20
                {
                    this.div_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.div_btn).Click += this.div_btn_Click;
                }
                break;
            case 10: // MainPage.xaml line 22
                {
                    this.result = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
