﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScreenshotBrower.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ScreenshotBrower.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 [{&quot;text&quot;:&quot;Australia&quot;,&quot;id&quot;:&quot;GLUXCountryList_0&quot;},{&quot;text&quot;:&quot;Canada&quot;,&quot;id&quot;:&quot;GLUXCountryList_1&quot;},{&quot;text&quot;:&quot;China&quot;,&quot;id&quot;:&quot;GLUXCountryList_2&quot;},{&quot;text&quot;:&quot;Japan&quot;,&quot;id&quot;:&quot;GLUXCountryList_3&quot;},{&quot;text&quot;:&quot;Mexico&quot;,&quot;id&quot;:&quot;GLUXCountryList_4&quot;},{&quot;text&quot;:&quot;Singapore&quot;,&quot;id&quot;:&quot;GLUXCountryList_5&quot;},{&quot;text&quot;:&quot;United Kingdom&quot;,&quot;id&quot;:&quot;GLUXCountryList_6&quot;},{&quot;text&quot;:&quot;Afghanistan&quot;,&quot;id&quot;:&quot;GLUXCountryList_7&quot;},{&quot;text&quot;:&quot;Aland Islands&quot;,&quot;id&quot;:&quot;GLUXCountryList_8&quot;},{&quot;text&quot;:&quot;Albania&quot;,&quot;id&quot;:&quot;GLUXCountryList_9&quot;},{&quot;text&quot;:&quot;Algeria&quot;,&quot;id&quot;:&quot;GLUXCountryList_10&quot;},{&quot;text&quot;:&quot;Am [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string country {
            get {
                return ResourceManager.GetString("country", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap detail_head {
            get {
                object obj = ResourceManager.GetObject("detail_head", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon favicon {
            get {
                object obj = ResourceManager.GetObject("favicon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Inventory_head {
            get {
                object obj = ResourceManager.GetObject("Inventory_head", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap list_head {
            get {
                object obj = ResourceManager.GetObject("list_head", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 function oAddContent(text)
        ///{
        ///	var nodep=document.createElement(&apos;p&apos;);
        ///	var node2=document.createElement(&apos;span&apos;);
        ///	node2.style=&quot;display: inline-block;margin-left: 400px;&quot;;
        ///	node2.innerText=text;
        ///	
        ///	var node=document.createElement(&apos;h2&apos;);
        ///	node.innerText=document.URL;		
        ///	node.append(node2);	
        ///	node.append(nodep);
        ///	node.append(nodep.cloneNode(true));
        ///		
        ///	document.body.firstChild.before(node);	
        ///	document.body.lastChild.after(node.cloneNode(true));
        ///	
        ///	document.getElementById(&apos;skiplink&apos;).remove();
        ///} 的本地化字符串。
        /// </summary>
        internal static string oAddContent {
            get {
                return ResourceManager.GetString("oAddContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ()=&gt;{
        ///    try {		
        ///		var addr=document.querySelector(&apos;r2&apos;);		
        ///		var index1=addr.innerHTML.length;	
        ///		var line1=addr.innerHTML.slice(0,10)+&apos;&lt;c style=&quot;filter:blur(3px)&quot;&gt;&apos;+addr.innerHTML.slice(10,index1)+&quot;&lt;/c&gt;&quot;;				
        ///		addr.innerHTML=line1;
        ///        return 1;
        ///    } catch (error) {
        ///        return 0;
        ///    }
        ///} 的本地化字符串。
        /// </summary>
        internal static string oBlurDetail {
            get {
                return ResourceManager.GetString("oBlurDetail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ()=&gt;{	
        ///	try{		
        ///		var node1=document.querySelector(&quot;#imgDiv &gt; table &gt; tbody &gt; tr:nth-child(4) &gt; td:nth-child(1)&quot;);
        ///		var index1=node1.innerHTML.indexOf(&apos;&lt;b&gt;Address:&lt;/b&gt;&apos;);
        ///		var index11=node1.innerHTML.indexOf(&apos; United States&lt;br&gt;&apos;);
        ///		var index2=node1.innerHTML.indexOf(&apos;&lt;b&gt;ZIP:&lt;/b&gt;&apos;);
        ///		var index3=node1.innerHTML.indexOf(&apos;&lt;b&gt;Purchase Date:&lt;/b&gt;&apos;);
        ///		var line1=node1.innerHTML.slice(0,index1+15+10)+&apos;&lt;c style=&quot;filter:blur(3px)&quot;&gt;&apos;+node1.innerHTML.slice(index1+15+10,index11-1)+&apos;&lt;/c&gt;&apos;+node1.innerHTML.slice(i [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string oBlurInvoice {
            get {
                return ResourceManager.GetString("oBlurInvoice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ()=&gt;{
        ///    try {
        ///        document.querySelectorAll(&apos;body &gt; div.main &gt; div.main-right &gt; table &gt; tbody &gt; tr &gt; td.details &gt; a:nth-child(3)&apos;).forEach(c =&gt; c.style = &apos;filter:blur(3px)&apos;);
        ///        return 1;
        ///    } catch (error) {
        ///        return 0;
        ///    }
        ///
        ///} 的本地化字符串。
        /// </summary>
        internal static string oBlurList {
            get {
                return ResourceManager.GetString("oBlurList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 function oChange(num)
        ///{
        ///		document.getElementById(&apos;nav-packard-glow-loc-icon&apos;).click();//open dialog	
        ///		setTimeout(function()
        ///		{
        ///			document.getElementById(&apos;GLUXChangePostalCodeLink&apos;).click(); //click change
        ///		},2000);	
        ///		setTimeout(function(){
        ///			document.getElementById(&apos;GLUXZipUpdateInput&apos;).value=num; //input num
        ///		},4000);	
        ///		setTimeout(function(){
        ///		document.getElementById(&apos;GLUXZipUpdate-announce&apos;).click();//change
        ///		},6000);		
        ///		setTimeout(function(){
        ///		var sbtn=document.querySelector(&apos;b [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string oChange {
            get {
                return ResourceManager.GetString("oChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 function oChange(num)
        ///{
        ///		document.getElementById(&apos;nav-packard-glow-loc-icon&apos;).click();//open dialog	
        ///		setTimeout(function()
        ///		{
        ///			document.getElementById(&apos;GLUXCountryList&apos;).click();  //click change
        ///		},2000);	
        ///		setTimeout(function(){
        ///			document.getElementById(num).click();
        ///		},4000);	
        ///		
        ///		setTimeout(function(){
        ///		var sbtn=document.querySelector(&apos;button[name=&quot;glowDoneButton&quot;]&apos;);//apply
        ///		if(sbtn==null)
        ///		{
        ///			sbtn=document.getElementById(&apos;GLUXConfirmClose&apos;);
        ///		}
        ///		if(sbtn!=null)
        ///		{
        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string oChange2 {
            get {
                return ResourceManager.GetString("oChange2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ()=&gt;{
        ///	try{
        ///		var clicknum=Math.round(Math.random()*10);		
        ///		var list=document.querySelectorAll(&apos;#rhf-container  a.a-button.a-button-image.a-carousel-button.a-carousel-goto-nextpage&apos;);
        ///		if(list.length&gt;2)
        ///		{
        ///			if(clicknum==1)
        ///			{
        ///				list[0].click();
        ///			}
        ///			if(clicknum==2)
        ///			{			
        ///				list[1].click();
        ///			}
        ///		}
        ///		var asin7=document.querySelector(&apos;.rhf-footer [aria-posinset=&quot;7&quot;]&apos;);
        ///		if(asin7!=null)
        ///		{
        ///			asin7.remove();
        ///		}
        ///		return 1;
        ///	}catch(ex)
        ///	{	
        ///		console.log(ex);
        ///		return  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string oRandom {
            get {
                return ResourceManager.GetString("oRandom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://www.amazon.com/dp/B07D6XQQRY
        ///https://www.amazon.com/dp/B07KPQKWP2
        ///https://www.amazon.com/dp/B0843HCT63
        ///https://www.amazon.com/dp/B081YSP2WY
        ///https://www.amazon.com/dp/B01J3BIH2Y
        ///https://www.amazon.com/dp/B00YFHOAHS
        ///https://www.amazon.com/dp/B00PYM7QEW
        ///https://www.amazon.com/dp/B07ZS2ND6J
        ///https://www.amazon.com/dp/B07YKTYZJ6
        ///https://www.amazon.com/dp/B00SZDHI72
        ///https://www.amazon.com/dp/B01ENU0V5Q
        ///https://www.amazon.com/dp/B07NCCNNXN
        ///https://www.amazon.com/dp/B087YCZR73
        ///https://www.amazon [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string preload {
            get {
                return ResourceManager.GetString("preload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 83707
        ///83706
        ///83705
        ///83704
        ///83703
        ///83702
        ///83701
        ///83680
        ///83669
        ///83642
        ///83634
        ///83616
        ///74965
        ///74964
        ///74960
        ///74931
        ///74457
        ///63559
        ///63546
        ///63540
        ///63533
        ///63501
        ///42753
        ///42742
        ///42741
        ///42728
        ///42720
        ///42715
        ///50858
        ///50849
        ///50846
        ///50837
        ///50002
        ///74965
        ///74964
        ///74960
        ///74931 的本地化字符串。
        /// </summary>
        internal static string zip {
            get {
                return ResourceManager.GetString("zip", resourceCulture);
            }
        }
    }
}
