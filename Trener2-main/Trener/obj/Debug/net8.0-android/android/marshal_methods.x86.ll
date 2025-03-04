; ModuleID = 'marshal_methods.x86.ll'
source_filename = "marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [323 x ptr] zeroinitializer, align 4

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [640 x i32] [
	i32 2616222, ; 0: System.Net.NetworkInformation.dll => 0x27eb9e => 69
	i32 10166715, ; 1: System.Net.NameResolution.dll => 0x9b21bb => 68
	i32 15721112, ; 2: System.Runtime.Intrinsics.dll => 0xefe298 => 109
	i32 32687329, ; 3: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 240
	i32 34715100, ; 4: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 274
	i32 34839235, ; 5: System.IO.FileSystem.DriveInfo => 0x2139ac3 => 49
	i32 39485524, ; 6: System.Net.WebSockets.dll => 0x25a8054 => 81
	i32 42639949, ; 7: System.Threading.Thread => 0x28aa24d => 146
	i32 66541672, ; 8: System.Diagnostics.StackTrace => 0x3f75868 => 31
	i32 67008169, ; 9: zh-Hant\Microsoft.Maui.Controls.resources => 0x3fe76a9 => 315
	i32 68219467, ; 10: System.Security.Cryptography.Primitives => 0x410f24b => 125
	i32 72070932, ; 11: Microsoft.Maui.Graphics.dll => 0x44bb714 => 189
	i32 82292897, ; 12: System.Runtime.CompilerServices.VisualC.dll => 0x4e7b0a1 => 103
	i32 101534019, ; 13: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 258
	i32 117431740, ; 14: System.Runtime.InteropServices => 0x6ffddbc => 108
	i32 120558881, ; 15: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 258
	i32 122350210, ; 16: System.Threading.Channels.dll => 0x74aea82 => 140
	i32 134690465, ; 17: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 278
	i32 142721839, ; 18: System.Net.WebHeaderCollection => 0x881c32f => 78
	i32 149972175, ; 19: System.Security.Cryptography.Primitives.dll => 0x8f064cf => 125
	i32 151607338, ; 20: NAudio.Wasapi => 0x909582a => 194
	i32 159306688, ; 21: System.ComponentModel.Annotations => 0x97ed3c0 => 15
	i32 165246403, ; 22: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 214
	i32 176265551, ; 23: System.ServiceProcess => 0xa81994f => 133
	i32 182336117, ; 24: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 260
	i32 184328833, ; 25: System.ValueTuple.dll => 0xafca281 => 152
	i32 195452805, ; 26: vi/Microsoft.Maui.Controls.resources.dll => 0xba65f85 => 312
	i32 199333315, ; 27: zh-HK/Microsoft.Maui.Controls.resources.dll => 0xbe195c3 => 313
	i32 205061960, ; 28: System.ComponentModel => 0xc38ff48 => 20
	i32 209399409, ; 29: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 212
	i32 220171995, ; 30: System.Diagnostics.Debug => 0xd1f8edb => 28
	i32 230216969, ; 31: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 234
	i32 230752869, ; 32: Microsoft.CSharp.dll => 0xdc10265 => 3
	i32 231409092, ; 33: System.Linq.Parallel => 0xdcb05c4 => 60
	i32 231814094, ; 34: System.Globalization => 0xdd133ce => 43
	i32 246610117, ; 35: System.Reflection.Emit.Lightweight => 0xeb2f8c5 => 92
	i32 261689757, ; 36: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 217
	i32 276479776, ; 37: System.Threading.Timer.dll => 0x107abf20 => 148
	i32 278686392, ; 38: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 236
	i32 280482487, ; 39: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 233
	i32 280992041, ; 40: cs/Microsoft.Maui.Controls.resources.dll => 0x10bf9929 => 284
	i32 291076382, ; 41: System.IO.Pipes.AccessControl.dll => 0x1159791e => 55
	i32 298918909, ; 42: System.Net.Ping.dll => 0x11d123fd => 70
	i32 317674968, ; 43: vi\Microsoft.Maui.Controls.resources => 0x12ef55d8 => 312
	i32 318968648, ; 44: Xamarin.AndroidX.Activity.dll => 0x13031348 => 203
	i32 321597661, ; 45: System.Numerics => 0x132b30dd => 84
	i32 336156722, ; 46: ja/Microsoft.Maui.Controls.resources.dll => 0x14095832 => 297
	i32 342366114, ; 47: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 235
	i32 356389973, ; 48: it/Microsoft.Maui.Controls.resources.dll => 0x153e1455 => 296
	i32 360082299, ; 49: System.ServiceModel.Web => 0x15766b7b => 132
	i32 367780167, ; 50: System.IO.Pipes => 0x15ebe147 => 56
	i32 374914964, ; 51: System.Transactions.Local => 0x1658bf94 => 150
	i32 375677976, ; 52: System.Net.ServicePoint.dll => 0x16646418 => 75
	i32 379916513, ; 53: System.Threading.Thread.dll => 0x16a510e1 => 146
	i32 385762202, ; 54: System.Memory.dll => 0x16fe439a => 63
	i32 392610295, ; 55: System.Threading.ThreadPool.dll => 0x1766c1f7 => 147
	i32 395744057, ; 56: _Microsoft.Android.Resource.Designer => 0x17969339 => 319
	i32 403441872, ; 57: WindowsBase => 0x180c08d0 => 166
	i32 435591531, ; 58: sv/Microsoft.Maui.Controls.resources.dll => 0x19f6996b => 308
	i32 441335492, ; 59: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 218
	i32 442565967, ; 60: System.Collections => 0x1a61054f => 14
	i32 450948140, ; 61: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 231
	i32 451504562, ; 62: System.Security.Cryptography.X509Certificates => 0x1ae969b2 => 126
	i32 456227837, ; 63: System.Web.HttpUtility.dll => 0x1b317bfd => 153
	i32 459347974, ; 64: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 114
	i32 465846621, ; 65: mscorlib => 0x1bc4415d => 167
	i32 469710990, ; 66: System.dll => 0x1bff388e => 165
	i32 476646585, ; 67: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 233
	i32 486930444, ; 68: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 246
	i32 498788369, ; 69: System.ObjectModel => 0x1dbae811 => 85
	i32 500358224, ; 70: id/Microsoft.Maui.Controls.resources.dll => 0x1dd2dc50 => 295
	i32 503918385, ; 71: fi/Microsoft.Maui.Controls.resources.dll => 0x1e092f31 => 289
	i32 513247710, ; 72: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 183
	i32 525008092, ; 73: SkiaSharp.dll => 0x1f4afcdc => 197
	i32 526420162, ; 74: System.Transactions.dll => 0x1f6088c2 => 151
	i32 527452488, ; 75: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 278
	i32 530272170, ; 76: System.Linq.Queryable => 0x1f9b4faa => 61
	i32 539058512, ; 77: Microsoft.Extensions.Logging => 0x20216150 => 179
	i32 540030774, ; 78: System.IO.FileSystem.dll => 0x20303736 => 52
	i32 545304856, ; 79: System.Runtime.Extensions => 0x2080b118 => 104
	i32 546455878, ; 80: System.Runtime.Serialization.Xml => 0x20924146 => 115
	i32 549171840, ; 81: System.Globalization.Calendars => 0x20bbb280 => 41
	i32 557405415, ; 82: Jsr305Binding => 0x213954e7 => 271
	i32 569601784, ; 83: Xamarin.AndroidX.Window.Extensions.Core.Core => 0x21f36ef8 => 269
	i32 577335427, ; 84: System.Security.Cryptography.Cng => 0x22697083 => 121
	i32 592146354, ; 85: pt-BR/Microsoft.Maui.Controls.resources.dll => 0x234b6fb2 => 303
	i32 601371474, ; 86: System.IO.IsolatedStorage.dll => 0x23d83352 => 53
	i32 605376203, ; 87: System.IO.Compression.FileSystem => 0x24154ecb => 45
	i32 613668793, ; 88: System.Security.Cryptography.Algorithms => 0x2493d7b9 => 120
	i32 627609679, ; 89: Xamarin.AndroidX.CustomView => 0x2568904f => 223
	i32 627931235, ; 90: nl\Microsoft.Maui.Controls.resources => 0x256d7863 => 301
	i32 639843206, ; 91: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 229
	i32 643868501, ; 92: System.Net => 0x2660a755 => 82
	i32 662205335, ; 93: System.Text.Encodings.Web.dll => 0x27787397 => 137
	i32 663517072, ; 94: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 265
	i32 666292255, ; 95: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 210
	i32 672442732, ; 96: System.Collections.Concurrent => 0x2814a96c => 10
	i32 683518922, ; 97: System.Net.Security => 0x28bdabca => 74
	i32 688181140, ; 98: ca/Microsoft.Maui.Controls.resources.dll => 0x2904cf94 => 283
	i32 690569205, ; 99: System.Xml.Linq.dll => 0x29293ff5 => 156
	i32 691348768, ; 100: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 280
	i32 693804605, ; 101: System.Windows => 0x295a9e3d => 155
	i32 699345723, ; 102: System.Reflection.Emit => 0x29af2b3b => 93
	i32 700284507, ; 103: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 275
	i32 700358131, ; 104: System.IO.Compression.ZipFile => 0x29be9df3 => 46
	i32 706645707, ; 105: ko/Microsoft.Maui.Controls.resources.dll => 0x2a1e8ecb => 298
	i32 709557578, ; 106: de/Microsoft.Maui.Controls.resources.dll => 0x2a4afd4a => 286
	i32 720511267, ; 107: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 279
	i32 722857257, ; 108: System.Runtime.Loader.dll => 0x2b15ed29 => 110
	i32 735137430, ; 109: System.Security.SecureString.dll => 0x2bd14e96 => 130
	i32 752232764, ; 110: System.Diagnostics.Contracts.dll => 0x2cd6293c => 27
	i32 755313932, ; 111: Xamarin.Android.Glide.Annotations.dll => 0x2d052d0c => 200
	i32 759454413, ; 112: System.Net.Requests => 0x2d445acd => 73
	i32 762598435, ; 113: System.IO.Pipes.dll => 0x2d745423 => 56
	i32 775507847, ; 114: System.IO.Compression => 0x2e394f87 => 47
	i32 777317022, ; 115: sk\Microsoft.Maui.Controls.resources => 0x2e54ea9e => 307
	i32 789151979, ; 116: Microsoft.Extensions.Options => 0x2f0980eb => 182
	i32 790371945, ; 117: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 224
	i32 804715423, ; 118: System.Data.Common => 0x2ff6fb9f => 24
	i32 807930345, ; 119: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx.dll => 0x302809e9 => 238
	i32 823281589, ; 120: System.Private.Uri.dll => 0x311247b5 => 87
	i32 830298997, ; 121: System.IO.Compression.Brotli => 0x317d5b75 => 44
	i32 832635846, ; 122: System.Xml.XPath.dll => 0x31a103c6 => 161
	i32 834051424, ; 123: System.Net.Quic => 0x31b69d60 => 72
	i32 843511501, ; 124: Xamarin.AndroidX.Print => 0x3246f6cd => 251
	i32 873119928, ; 125: Microsoft.VisualBasic => 0x340ac0b8 => 5
	i32 877678880, ; 126: System.Globalization.dll => 0x34505120 => 43
	i32 878954865, ; 127: System.Net.Http.Json => 0x3463c971 => 64
	i32 904024072, ; 128: System.ComponentModel.Primitives.dll => 0x35e25008 => 18
	i32 911108515, ; 129: System.IO.MemoryMappedFiles.dll => 0x364e69a3 => 54
	i32 926902833, ; 130: tr/Microsoft.Maui.Controls.resources.dll => 0x373f6a31 => 310
	i32 928116545, ; 131: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 274
	i32 952186615, ; 132: System.Runtime.InteropServices.JavaScript.dll => 0x38c136f7 => 106
	i32 956575887, ; 133: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 279
	i32 966729478, ; 134: Xamarin.Google.Crypto.Tink.Android => 0x399f1f06 => 272
	i32 967690846, ; 135: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 235
	i32 975236339, ; 136: System.Diagnostics.Tracing => 0x3a20ecf3 => 35
	i32 975874589, ; 137: System.Xml.XDocument => 0x3a2aaa1d => 159
	i32 986514023, ; 138: System.Private.DataContractSerialization.dll => 0x3acd0267 => 86
	i32 987214855, ; 139: System.Diagnostics.Tools => 0x3ad7b407 => 33
	i32 992768348, ; 140: System.Collections.dll => 0x3b2c715c => 14
	i32 994442037, ; 141: System.IO.FileSystem => 0x3b45fb35 => 52
	i32 1001831731, ; 142: System.IO.UnmanagedMemoryStream.dll => 0x3bb6bd33 => 57
	i32 1012816738, ; 143: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 255
	i32 1019214401, ; 144: System.Drawing => 0x3cbffa41 => 37
	i32 1028951442, ; 145: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 178
	i32 1029334545, ; 146: da/Microsoft.Maui.Controls.resources.dll => 0x3d5a6611 => 285
	i32 1031528504, ; 147: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 273
	i32 1035644815, ; 148: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 208
	i32 1036536393, ; 149: System.Drawing.Primitives.dll => 0x3dc84a49 => 36
	i32 1044663988, ; 150: System.Linq.Expressions.dll => 0x3e444eb4 => 59
	i32 1052210849, ; 151: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 242
	i32 1067306892, ; 152: GoogleGson => 0x3f9dcf8c => 174
	i32 1082857460, ; 153: System.ComponentModel.TypeConverter => 0x408b17f4 => 19
	i32 1084122840, ; 154: Xamarin.Kotlin.StdLib => 0x409e66d8 => 276
	i32 1098259244, ; 155: System => 0x41761b2c => 165
	i32 1118262833, ; 156: ko\Microsoft.Maui.Controls.resources => 0x42a75631 => 298
	i32 1121599056, ; 157: Xamarin.AndroidX.Lifecycle.Runtime.Ktx.dll => 0x42da3e50 => 241
	i32 1127624469, ; 158: Microsoft.Extensions.Logging.Debug => 0x43362f15 => 181
	i32 1149092582, ; 159: Xamarin.AndroidX.Window => 0x447dc2e6 => 268
	i32 1168523401, ; 160: pt\Microsoft.Maui.Controls.resources => 0x45a64089 => 304
	i32 1170634674, ; 161: System.Web.dll => 0x45c677b2 => 154
	i32 1175144683, ; 162: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 264
	i32 1178241025, ; 163: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 249
	i32 1203215381, ; 164: pl/Microsoft.Maui.Controls.resources.dll => 0x47b79c15 => 302
	i32 1204270330, ; 165: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 210
	i32 1208641965, ; 166: System.Diagnostics.Process => 0x480a69ad => 30
	i32 1219128291, ; 167: System.IO.IsolatedStorage => 0x48aa6be3 => 53
	i32 1234928153, ; 168: nb/Microsoft.Maui.Controls.resources.dll => 0x499b8219 => 300
	i32 1243150071, ; 169: Xamarin.AndroidX.Window.Extensions.Core.Core.dll => 0x4a18f6f7 => 269
	i32 1253011324, ; 170: Microsoft.Win32.Registry => 0x4aaf6f7c => 7
	i32 1260983243, ; 171: cs\Microsoft.Maui.Controls.resources => 0x4b2913cb => 284
	i32 1264511973, ; 172: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 259
	i32 1267360935, ; 173: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 263
	i32 1273260888, ; 174: Xamarin.AndroidX.Collection.Ktx => 0x4be46b58 => 215
	i32 1275534314, ; 175: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 280
	i32 1278448581, ; 176: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 207
	i32 1293217323, ; 177: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 226
	i32 1297443132, ; 178: cs\Trener.resources => 0x4d55693c => 0
	i32 1309188875, ; 179: System.Private.DataContractSerialization => 0x4e08a30b => 86
	i32 1322716291, ; 180: Xamarin.AndroidX.Window.dll => 0x4ed70c83 => 268
	i32 1324164729, ; 181: System.Linq => 0x4eed2679 => 62
	i32 1335329327, ; 182: System.Runtime.Serialization.Json.dll => 0x4f97822f => 113
	i32 1347751866, ; 183: Plugin.Maui.Audio => 0x50550fba => 196
	i32 1364015309, ; 184: System.IO => 0x514d38cd => 58
	i32 1373134921, ; 185: zh-Hans\Microsoft.Maui.Controls.resources => 0x51d86049 => 314
	i32 1376866003, ; 186: Xamarin.AndroidX.SavedState => 0x52114ed3 => 255
	i32 1379779777, ; 187: System.Resources.ResourceManager => 0x523dc4c1 => 100
	i32 1402170036, ; 188: System.Configuration.dll => 0x53936ab4 => 21
	i32 1406073936, ; 189: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 219
	i32 1408764838, ; 190: System.Runtime.Serialization.Formatters.dll => 0x53f80ba6 => 112
	i32 1411638395, ; 191: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 102
	i32 1422545099, ; 192: System.Runtime.CompilerServices.VisualC => 0x54ca50cb => 103
	i32 1430672901, ; 193: ar\Microsoft.Maui.Controls.resources => 0x55465605 => 282
	i32 1434145427, ; 194: System.Runtime.Handles => 0x557b5293 => 105
	i32 1435222561, ; 195: Xamarin.Google.Crypto.Tink.Android.dll => 0x558bc221 => 272
	i32 1439761251, ; 196: System.Net.Quic.dll => 0x55d10363 => 72
	i32 1452070440, ; 197: System.Formats.Asn1.dll => 0x568cd628 => 39
	i32 1453312822, ; 198: System.Diagnostics.Tools.dll => 0x569fcb36 => 33
	i32 1457743152, ; 199: System.Runtime.Extensions.dll => 0x56e36530 => 104
	i32 1458022317, ; 200: System.Net.Security.dll => 0x56e7a7ad => 74
	i32 1461004990, ; 201: es\Microsoft.Maui.Controls.resources => 0x57152abe => 288
	i32 1461234159, ; 202: System.Collections.Immutable.dll => 0x5718a9ef => 11
	i32 1461719063, ; 203: System.Security.Cryptography.OpenSsl => 0x57201017 => 124
	i32 1462112819, ; 204: System.IO.Compression.dll => 0x57261233 => 47
	i32 1469204771, ; 205: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 209
	i32 1470490898, ; 206: Microsoft.Extensions.Primitives => 0x57a5e912 => 183
	i32 1479771757, ; 207: System.Collections.Immutable => 0x5833866d => 11
	i32 1480492111, ; 208: System.IO.Compression.Brotli.dll => 0x583e844f => 44
	i32 1487239319, ; 209: Microsoft.Win32.Primitives => 0x58a57897 => 6
	i32 1489956495, ; 210: NAudio.Core => 0x58ceee8f => 192
	i32 1490025113, ; 211: Xamarin.AndroidX.SavedState.SavedState.Ktx.dll => 0x58cffa99 => 256
	i32 1493001747, ; 212: hi/Microsoft.Maui.Controls.resources.dll => 0x58fd6613 => 292
	i32 1495870163, ; 213: NAudio.Midi.dll => 0x59292ad3 => 193
	i32 1514721132, ; 214: el/Microsoft.Maui.Controls.resources.dll => 0x5a48cf6c => 287
	i32 1536373174, ; 215: System.Diagnostics.TextWriterTraceListener => 0x5b9331b6 => 32
	i32 1543031311, ; 216: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 139
	i32 1543355203, ; 217: System.Reflection.Emit.dll => 0x5bfdbb43 => 93
	i32 1543663015, ; 218: en\Trener.resources => 0x5c026da7 => 1
	i32 1550322496, ; 219: System.Reflection.Extensions.dll => 0x5c680b40 => 94
	i32 1551623176, ; 220: sk/Microsoft.Maui.Controls.resources.dll => 0x5c7be408 => 307
	i32 1565862583, ; 221: System.IO.FileSystem.Primitives => 0x5d552ab7 => 50
	i32 1566207040, ; 222: System.Threading.Tasks.Dataflow.dll => 0x5d5a6c40 => 142
	i32 1573704789, ; 223: System.Runtime.Serialization.Json => 0x5dccd455 => 113
	i32 1580037396, ; 224: System.Threading.Overlapped => 0x5e2d7514 => 141
	i32 1582372066, ; 225: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 225
	i32 1592978981, ; 226: System.Runtime.Serialization.dll => 0x5ef2ee25 => 116
	i32 1597949149, ; 227: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 273
	i32 1601112923, ; 228: System.Xml.Serialization => 0x5f6f0b5b => 158
	i32 1603525486, ; 229: Microsoft.Maui.Controls.HotReload.Forms.dll => 0x5f93db6e => 316
	i32 1604827217, ; 230: System.Net.WebClient => 0x5fa7b851 => 77
	i32 1618516317, ; 231: System.Net.WebSockets.Client.dll => 0x6078995d => 80
	i32 1622152042, ; 232: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 245
	i32 1622358360, ; 233: System.Dynamic.Runtime => 0x60b33958 => 38
	i32 1624863272, ; 234: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 267
	i32 1635184631, ; 235: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 229
	i32 1636350590, ; 236: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 222
	i32 1639515021, ; 237: System.Net.Http.dll => 0x61b9038d => 65
	i32 1639986890, ; 238: System.Text.RegularExpressions => 0x61c036ca => 139
	i32 1641389582, ; 239: System.ComponentModel.EventBasedAsync.dll => 0x61d59e0e => 17
	i32 1654915987, ; 240: NAudio => 0x62a40393 => 190
	i32 1657153582, ; 241: System.Runtime => 0x62c6282e => 117
	i32 1658241508, ; 242: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 261
	i32 1658251792, ; 243: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 270
	i32 1670060433, ; 244: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 217
	i32 1675553242, ; 245: System.IO.FileSystem.DriveInfo.dll => 0x63dee9da => 49
	i32 1677501392, ; 246: System.Net.Primitives.dll => 0x63fca3d0 => 71
	i32 1678508291, ; 247: System.Net.WebSockets => 0x640c0103 => 81
	i32 1679769178, ; 248: System.Security.Cryptography => 0x641f3e5a => 127
	i32 1691477237, ; 249: System.Reflection.Metadata => 0x64d1e4f5 => 95
	i32 1696967625, ; 250: System.Security.Cryptography.Csp => 0x6525abc9 => 122
	i32 1698840827, ; 251: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 277
	i32 1701541528, ; 252: System.Diagnostics.Debug.dll => 0x656b7698 => 28
	i32 1720223769, ; 253: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx => 0x66888819 => 238
	i32 1726116996, ; 254: System.Reflection.dll => 0x66e27484 => 98
	i32 1728033016, ; 255: System.Diagnostics.FileVersionInfo.dll => 0x66ffb0f8 => 29
	i32 1729485958, ; 256: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 213
	i32 1736233607, ; 257: ro/Microsoft.Maui.Controls.resources.dll => 0x677cd287 => 305
	i32 1743415430, ; 258: ca\Microsoft.Maui.Controls.resources => 0x67ea6886 => 283
	i32 1744735666, ; 259: System.Transactions.Local.dll => 0x67fe8db2 => 150
	i32 1746316138, ; 260: Mono.Android.Export => 0x6816ab6a => 170
	i32 1750313021, ; 261: Microsoft.Win32.Primitives.dll => 0x6853a83d => 6
	i32 1758240030, ; 262: System.Resources.Reader.dll => 0x68cc9d1e => 99
	i32 1763938596, ; 263: System.Diagnostics.TraceSource.dll => 0x69239124 => 34
	i32 1765942094, ; 264: System.Reflection.Extensions => 0x6942234e => 94
	i32 1766324549, ; 265: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 260
	i32 1770582343, ; 266: Microsoft.Extensions.Logging.dll => 0x6988f147 => 179
	i32 1776026572, ; 267: System.Core.dll => 0x69dc03cc => 23
	i32 1777075843, ; 268: System.Globalization.Extensions.dll => 0x69ec0683 => 42
	i32 1780572499, ; 269: Mono.Android.Runtime.dll => 0x6a216153 => 171
	i32 1782862114, ; 270: ms\Microsoft.Maui.Controls.resources => 0x6a445122 => 299
	i32 1788241197, ; 271: Xamarin.AndroidX.Fragment => 0x6a96652d => 231
	i32 1793755602, ; 272: he\Microsoft.Maui.Controls.resources => 0x6aea89d2 => 291
	i32 1808609942, ; 273: Xamarin.AndroidX.Loader => 0x6bcd3296 => 245
	i32 1813058853, ; 274: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 276
	i32 1813201214, ; 275: Xamarin.Google.Android.Material => 0x6c13413e => 270
	i32 1818569960, ; 276: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 250
	i32 1818787751, ; 277: Microsoft.VisualBasic.Core => 0x6c687fa7 => 4
	i32 1824175904, ; 278: System.Text.Encoding.Extensions => 0x6cbab720 => 135
	i32 1824722060, ; 279: System.Runtime.Serialization.Formatters => 0x6cc30c8c => 112
	i32 1827303595, ; 280: Microsoft.VisualStudio.DesignTools.TapContract => 0x6cea70ab => 318
	i32 1828688058, ; 281: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 180
	i32 1842015223, ; 282: uk/Microsoft.Maui.Controls.resources.dll => 0x6dcaebf7 => 311
	i32 1847515442, ; 283: Xamarin.Android.Glide.Annotations => 0x6e1ed932 => 200
	i32 1853025655, ; 284: sv\Microsoft.Maui.Controls.resources => 0x6e72ed77 => 308
	i32 1858542181, ; 285: System.Linq.Expressions => 0x6ec71a65 => 59
	i32 1870277092, ; 286: System.Reflection.Primitives => 0x6f7a29e4 => 96
	i32 1875935024, ; 287: fr\Microsoft.Maui.Controls.resources => 0x6fd07f30 => 290
	i32 1879696579, ; 288: System.Formats.Tar.dll => 0x7009e4c3 => 40
	i32 1885316902, ; 289: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 211
	i32 1885918049, ; 290: Microsoft.VisualStudio.DesignTools.TapContract.dll => 0x7068d361 => 318
	i32 1888955245, ; 291: System.Diagnostics.Contracts => 0x70972b6d => 27
	i32 1889954781, ; 292: System.Reflection.Metadata.dll => 0x70a66bdd => 95
	i32 1898237753, ; 293: System.Reflection.DispatchProxy => 0x7124cf39 => 90
	i32 1900610850, ; 294: System.Resources.ResourceManager.dll => 0x71490522 => 100
	i32 1910275211, ; 295: System.Collections.NonGeneric.dll => 0x71dc7c8b => 12
	i32 1939592360, ; 296: System.Private.Xml.Linq => 0x739bd4a8 => 88
	i32 1956758971, ; 297: System.Resources.Writer => 0x74a1c5bb => 101
	i32 1961813231, ; 298: Xamarin.AndroidX.Security.SecurityCrypto.dll => 0x74eee4ef => 257
	i32 1968388702, ; 299: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 175
	i32 1983156543, ; 300: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 277
	i32 1985761444, ; 301: Xamarin.Android.Glide.GifDecoder => 0x765c50a4 => 202
	i32 2003115576, ; 302: el\Microsoft.Maui.Controls.resources => 0x77651e38 => 287
	i32 2011961780, ; 303: System.Buffers.dll => 0x77ec19b4 => 9
	i32 2019465201, ; 304: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 242
	i32 2025202353, ; 305: ar/Microsoft.Maui.Controls.resources.dll => 0x78b622b1 => 282
	i32 2031763787, ; 306: Xamarin.Android.Glide => 0x791a414b => 199
	i32 2045470958, ; 307: System.Private.Xml => 0x79eb68ee => 89
	i32 2055257422, ; 308: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 237
	i32 2060060697, ; 309: System.Windows.dll => 0x7aca0819 => 155
	i32 2066184531, ; 310: de\Microsoft.Maui.Controls.resources => 0x7b277953 => 286
	i32 2070888862, ; 311: System.Diagnostics.TraceSource => 0x7b6f419e => 34
	i32 2079903147, ; 312: System.Runtime.dll => 0x7bf8cdab => 117
	i32 2090596640, ; 313: System.Numerics.Vectors => 0x7c9bf920 => 83
	i32 2127167465, ; 314: System.Console => 0x7ec9ffe9 => 22
	i32 2142473426, ; 315: System.Collections.Specialized => 0x7fb38cd2 => 13
	i32 2143790110, ; 316: System.Xml.XmlSerializer.dll => 0x7fc7a41e => 163
	i32 2146852085, ; 317: Microsoft.VisualBasic.dll => 0x7ff65cf5 => 5
	i32 2159891885, ; 318: Microsoft.Maui => 0x80bd55ad => 187
	i32 2169148018, ; 319: hu\Microsoft.Maui.Controls.resources => 0x814a9272 => 294
	i32 2181898931, ; 320: Microsoft.Extensions.Options.dll => 0x820d22b3 => 182
	i32 2192057212, ; 321: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 180
	i32 2193016926, ; 322: System.ObjectModel.dll => 0x82b6c85e => 85
	i32 2199201384, ; 323: NAudio.dll => 0x83152668 => 190
	i32 2201107256, ; 324: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 281
	i32 2201231467, ; 325: System.Net.Http => 0x8334206b => 65
	i32 2207618523, ; 326: it\Microsoft.Maui.Controls.resources => 0x839595db => 296
	i32 2217644978, ; 327: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 264
	i32 2222056684, ; 328: System.Threading.Tasks.Parallel => 0x8471e4ec => 144
	i32 2244775296, ; 329: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 246
	i32 2252106437, ; 330: System.Xml.Serialization.dll => 0x863c6ac5 => 158
	i32 2256313426, ; 331: System.Globalization.Extensions => 0x867c9c52 => 42
	i32 2265110946, ; 332: System.Security.AccessControl.dll => 0x8702d9a2 => 118
	i32 2266799131, ; 333: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 176
	i32 2267999099, ; 334: Xamarin.Android.Glide.DiskLruCache.dll => 0x872eeb7b => 201
	i32 2270573516, ; 335: fr/Microsoft.Maui.Controls.resources.dll => 0x875633cc => 290
	i32 2279755925, ; 336: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 253
	i32 2293034957, ; 337: System.ServiceModel.Web.dll => 0x88acefcd => 132
	i32 2295906218, ; 338: System.Net.Sockets => 0x88d8bfaa => 76
	i32 2298471582, ; 339: System.Net.Mail => 0x88ffe49e => 67
	i32 2303942373, ; 340: nb\Microsoft.Maui.Controls.resources => 0x89535ee5 => 300
	i32 2305521784, ; 341: System.Private.CoreLib.dll => 0x896b7878 => 173
	i32 2315684594, ; 342: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 205
	i32 2320631194, ; 343: System.Threading.Tasks.Parallel.dll => 0x8a52059a => 144
	i32 2340441535, ; 344: System.Runtime.InteropServices.RuntimeInformation.dll => 0x8b804dbf => 107
	i32 2344264397, ; 345: System.ValueTuple => 0x8bbaa2cd => 152
	i32 2353062107, ; 346: System.Net.Primitives => 0x8c40e0db => 71
	i32 2368005991, ; 347: System.Xml.ReaderWriter.dll => 0x8d24e767 => 157
	i32 2371007202, ; 348: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 175
	i32 2378619854, ; 349: System.Security.Cryptography.Csp.dll => 0x8dc6dbce => 122
	i32 2383496789, ; 350: System.Security.Principal.Windows.dll => 0x8e114655 => 128
	i32 2385305715, ; 351: NAudio.Wasapi.dll => 0x8e2ce073 => 194
	i32 2395872292, ; 352: id\Microsoft.Maui.Controls.resources => 0x8ece1c24 => 295
	i32 2401565422, ; 353: System.Web.HttpUtility => 0x8f24faee => 153
	i32 2403452196, ; 354: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 228
	i32 2409983638, ; 355: Microsoft.VisualStudio.DesignTools.MobileTapContracts.dll => 0x8fa56e96 => 317
	i32 2421380589, ; 356: System.Threading.Tasks.Dataflow => 0x905355ed => 142
	i32 2423080555, ; 357: Xamarin.AndroidX.Collection.Ktx.dll => 0x906d466b => 215
	i32 2427813419, ; 358: hi\Microsoft.Maui.Controls.resources => 0x90b57e2b => 292
	i32 2435356389, ; 359: System.Console.dll => 0x912896e5 => 22
	i32 2435904999, ; 360: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 16
	i32 2454642406, ; 361: System.Text.Encoding.dll => 0x924edee6 => 136
	i32 2458678730, ; 362: System.Net.Sockets.dll => 0x928c75ca => 76
	i32 2459001652, ; 363: System.Linq.Parallel.dll => 0x92916334 => 60
	i32 2465532216, ; 364: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 218
	i32 2471841756, ; 365: netstandard.dll => 0x93554fdc => 168
	i32 2475788418, ; 366: Java.Interop.dll => 0x93918882 => 169
	i32 2478825641, ; 367: cs/Trener.resources.dll => 0x93bfe0a9 => 0
	i32 2480646305, ; 368: Microsoft.Maui.Controls => 0x93dba8a1 => 185
	i32 2483903535, ; 369: System.ComponentModel.EventBasedAsync => 0x940d5c2f => 17
	i32 2484371297, ; 370: System.Net.ServicePoint => 0x94147f61 => 75
	i32 2490993605, ; 371: System.AppContext.dll => 0x94798bc5 => 8
	i32 2501346920, ; 372: System.Data.DataSetExtensions => 0x95178668 => 25
	i32 2505896520, ; 373: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 240
	i32 2522472828, ; 374: Xamarin.Android.Glide.dll => 0x9659e17c => 199
	i32 2538310050, ; 375: System.Reflection.Emit.Lightweight.dll => 0x974b89a2 => 92
	i32 2550873716, ; 376: hr\Microsoft.Maui.Controls.resources => 0x980b3e74 => 293
	i32 2562349572, ; 377: Microsoft.CSharp => 0x98ba5a04 => 3
	i32 2570120770, ; 378: System.Text.Encodings.Web => 0x9930ee42 => 137
	i32 2581783588, ; 379: Xamarin.AndroidX.Lifecycle.Runtime.Ktx => 0x99e2e424 => 241
	i32 2581819634, ; 380: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 263
	i32 2585220780, ; 381: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 135
	i32 2585805581, ; 382: System.Net.Ping => 0x9a20430d => 70
	i32 2589602615, ; 383: System.Threading.ThreadPool => 0x9a5a3337 => 147
	i32 2593496499, ; 384: pl\Microsoft.Maui.Controls.resources => 0x9a959db3 => 302
	i32 2605712449, ; 385: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 281
	i32 2615233544, ; 386: Xamarin.AndroidX.Fragment.Ktx => 0x9be14c08 => 232
	i32 2616218305, ; 387: Microsoft.Extensions.Logging.Debug.dll => 0x9bf052c1 => 181
	i32 2617129537, ; 388: System.Private.Xml.dll => 0x9bfe3a41 => 89
	i32 2618712057, ; 389: System.Reflection.TypeExtensions.dll => 0x9c165ff9 => 97
	i32 2620871830, ; 390: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 222
	i32 2624644809, ; 391: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 227
	i32 2626831493, ; 392: ja\Microsoft.Maui.Controls.resources => 0x9c924485 => 297
	i32 2627185994, ; 393: System.Diagnostics.TextWriterTraceListener.dll => 0x9c97ad4a => 32
	i32 2629843544, ; 394: System.IO.Compression.ZipFile.dll => 0x9cc03a58 => 46
	i32 2633051222, ; 395: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 236
	i32 2663391936, ; 396: Xamarin.Android.Glide.DiskLruCache => 0x9ec022c0 => 201
	i32 2663698177, ; 397: System.Runtime.Loader => 0x9ec4cf01 => 110
	i32 2664396074, ; 398: System.Xml.XDocument.dll => 0x9ecf752a => 159
	i32 2665622720, ; 399: System.Drawing.Primitives => 0x9ee22cc0 => 36
	i32 2676780864, ; 400: System.Data.Common.dll => 0x9f8c6f40 => 24
	i32 2686887180, ; 401: System.Runtime.Serialization.Xml.dll => 0xa026a50c => 115
	i32 2693849962, ; 402: System.IO.dll => 0xa090e36a => 58
	i32 2701096212, ; 403: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 261
	i32 2715334215, ; 404: System.Threading.Tasks.dll => 0xa1d8b647 => 145
	i32 2717744543, ; 405: System.Security.Claims => 0xa1fd7d9f => 119
	i32 2719963679, ; 406: System.Security.Cryptography.Cng.dll => 0xa21f5a1f => 121
	i32 2724373263, ; 407: System.Runtime.Numerics.dll => 0xa262a30f => 111
	i32 2732626843, ; 408: Xamarin.AndroidX.Activity => 0xa2e0939b => 203
	i32 2735172069, ; 409: System.Threading.Channels => 0xa30769e5 => 140
	i32 2737747696, ; 410: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 209
	i32 2740948882, ; 411: System.IO.Pipes.AccessControl => 0xa35f8f92 => 55
	i32 2748088231, ; 412: System.Runtime.InteropServices.JavaScript => 0xa3cc7fa7 => 106
	i32 2752995522, ; 413: pt-BR\Microsoft.Maui.Controls.resources => 0xa41760c2 => 303
	i32 2758225723, ; 414: Microsoft.Maui.Controls.Xaml => 0xa4672f3b => 186
	i32 2764765095, ; 415: Microsoft.Maui.dll => 0xa4caf7a7 => 187
	i32 2765824710, ; 416: System.Text.Encoding.CodePages.dll => 0xa4db22c6 => 134
	i32 2770495804, ; 417: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 275
	i32 2778768386, ; 418: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 266
	i32 2779977773, ; 419: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 254
	i32 2785988530, ; 420: th\Microsoft.Maui.Controls.resources => 0xa60ecfb2 => 309
	i32 2788224221, ; 421: Xamarin.AndroidX.Fragment.Ktx.dll => 0xa630ecdd => 232
	i32 2801831435, ; 422: Microsoft.Maui.Graphics => 0xa7008e0b => 189
	i32 2803228030, ; 423: System.Xml.XPath.XDocument.dll => 0xa715dd7e => 160
	i32 2806116107, ; 424: es/Microsoft.Maui.Controls.resources.dll => 0xa741ef0b => 288
	i32 2810250172, ; 425: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 219
	i32 2819470561, ; 426: System.Xml.dll => 0xa80db4e1 => 164
	i32 2821205001, ; 427: System.ServiceProcess.dll => 0xa8282c09 => 133
	i32 2821294376, ; 428: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 254
	i32 2824502124, ; 429: System.Xml.XmlDocument => 0xa85a7b6c => 162
	i32 2831556043, ; 430: nl/Microsoft.Maui.Controls.resources.dll => 0xa8c61dcb => 301
	i32 2838993487, ; 431: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx.dll => 0xa9379a4f => 243
	i32 2849599387, ; 432: System.Threading.Overlapped.dll => 0xa9d96f9b => 141
	i32 2853208004, ; 433: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 266
	i32 2855708567, ; 434: Xamarin.AndroidX.Transition => 0xaa36a797 => 262
	i32 2861098320, ; 435: Mono.Android.Export.dll => 0xaa88e550 => 170
	i32 2861189240, ; 436: Microsoft.Maui.Essentials => 0xaa8a4878 => 188
	i32 2870099610, ; 437: Xamarin.AndroidX.Activity.Ktx.dll => 0xab123e9a => 204
	i32 2875164099, ; 438: Jsr305Binding.dll => 0xab5f85c3 => 271
	i32 2875220617, ; 439: System.Globalization.Calendars.dll => 0xab606289 => 41
	i32 2884993177, ; 440: Xamarin.AndroidX.ExifInterface => 0xabf58099 => 230
	i32 2887636118, ; 441: System.Net.dll => 0xac1dd496 => 82
	i32 2899753641, ; 442: System.IO.UnmanagedMemoryStream => 0xacd6baa9 => 57
	i32 2900621748, ; 443: System.Dynamic.Runtime.dll => 0xace3f9b4 => 38
	i32 2901442782, ; 444: System.Reflection => 0xacf080de => 98
	i32 2905242038, ; 445: mscorlib.dll => 0xad2a79b6 => 167
	i32 2909740682, ; 446: System.Private.CoreLib => 0xad6f1e8a => 173
	i32 2916838712, ; 447: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 267
	i32 2917248660, ; 448: en/Trener.resources.dll => 0xade1ae94 => 1
	i32 2919462931, ; 449: System.Numerics.Vectors.dll => 0xae037813 => 83
	i32 2921128767, ; 450: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 206
	i32 2936416060, ; 451: System.Resources.Reader => 0xaf06273c => 99
	i32 2940926066, ; 452: System.Diagnostics.StackTrace.dll => 0xaf4af872 => 31
	i32 2942453041, ; 453: System.Xml.XPath.XDocument => 0xaf624531 => 160
	i32 2959614098, ; 454: System.ComponentModel.dll => 0xb0682092 => 20
	i32 2968338931, ; 455: System.Security.Principal.Windows => 0xb0ed41f3 => 128
	i32 2972252294, ; 456: System.Security.Cryptography.Algorithms.dll => 0xb128f886 => 120
	i32 2978675010, ; 457: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 226
	i32 2987532451, ; 458: Xamarin.AndroidX.Security.SecurityCrypto => 0xb21220a3 => 257
	i32 2991755712, ; 459: NAudio.Asio.dll => 0xb25291c0 => 191
	i32 2996846495, ; 460: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 239
	i32 3016983068, ; 461: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 259
	i32 3023353419, ; 462: WindowsBase.dll => 0xb434b64b => 166
	i32 3024354802, ; 463: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 234
	i32 3038032645, ; 464: _Microsoft.Android.Resource.Designer.dll => 0xb514b305 => 319
	i32 3056245963, ; 465: Xamarin.AndroidX.SavedState.SavedState.Ktx => 0xb62a9ccb => 256
	i32 3057625584, ; 466: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 247
	i32 3059408633, ; 467: Mono.Android.Runtime => 0xb65adef9 => 171
	i32 3059793426, ; 468: System.ComponentModel.Primitives => 0xb660be12 => 18
	i32 3061151445, ; 469: NAudio.WinMM => 0xb67576d5 => 195
	i32 3075834255, ; 470: System.Threading.Tasks => 0xb755818f => 145
	i32 3077302341, ; 471: hu/Microsoft.Maui.Controls.resources.dll => 0xb76be845 => 294
	i32 3081487099, ; 472: Trener.dll => 0xb7abc2fb => 2
	i32 3090735792, ; 473: System.Security.Cryptography.X509Certificates.dll => 0xb838e2b0 => 126
	i32 3099732863, ; 474: System.Security.Claims.dll => 0xb8c22b7f => 119
	i32 3103600923, ; 475: System.Formats.Asn1 => 0xb8fd311b => 39
	i32 3111772706, ; 476: System.Runtime.Serialization => 0xb979e222 => 116
	i32 3121463068, ; 477: System.IO.FileSystem.AccessControl.dll => 0xba0dbf1c => 48
	i32 3124832203, ; 478: System.Threading.Tasks.Extensions => 0xba4127cb => 143
	i32 3132293585, ; 479: System.Security.AccessControl => 0xbab301d1 => 118
	i32 3147165239, ; 480: System.Diagnostics.Tracing.dll => 0xbb95ee37 => 35
	i32 3148237826, ; 481: GoogleGson.dll => 0xbba64c02 => 174
	i32 3159123045, ; 482: System.Reflection.Primitives.dll => 0xbc4c6465 => 96
	i32 3160747431, ; 483: System.IO.MemoryMappedFiles => 0xbc652da7 => 54
	i32 3178803400, ; 484: Xamarin.AndroidX.Navigation.Fragment.dll => 0xbd78b0c8 => 248
	i32 3192346100, ; 485: System.Security.SecureString => 0xbe4755f4 => 130
	i32 3193515020, ; 486: System.Web => 0xbe592c0c => 154
	i32 3204380047, ; 487: System.Data.dll => 0xbefef58f => 26
	i32 3209718065, ; 488: System.Xml.XmlDocument.dll => 0xbf506931 => 162
	i32 3211777861, ; 489: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 225
	i32 3220365878, ; 490: System.Threading => 0xbff2e236 => 149
	i32 3226221578, ; 491: System.Runtime.Handles.dll => 0xc04c3c0a => 105
	i32 3251039220, ; 492: System.Reflection.DispatchProxy.dll => 0xc1c6ebf4 => 90
	i32 3258312781, ; 493: Xamarin.AndroidX.CardView => 0xc235e84d => 213
	i32 3265493905, ; 494: System.Linq.Queryable.dll => 0xc2a37b91 => 61
	i32 3265893370, ; 495: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 143
	i32 3277815716, ; 496: System.Resources.Writer.dll => 0xc35f7fa4 => 101
	i32 3279906254, ; 497: Microsoft.Win32.Registry.dll => 0xc37f65ce => 7
	i32 3280506390, ; 498: System.ComponentModel.Annotations.dll => 0xc3888e16 => 15
	i32 3290767353, ; 499: System.Security.Cryptography.Encoding => 0xc4251ff9 => 123
	i32 3299363146, ; 500: System.Text.Encoding => 0xc4a8494a => 136
	i32 3303498502, ; 501: System.Diagnostics.FileVersionInfo => 0xc4e76306 => 29
	i32 3305363605, ; 502: fi\Microsoft.Maui.Controls.resources => 0xc503d895 => 289
	i32 3316684772, ; 503: System.Net.Requests.dll => 0xc5b097e4 => 73
	i32 3317135071, ; 504: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 223
	i32 3317144872, ; 505: System.Data => 0xc5b79d28 => 26
	i32 3340387945, ; 506: SkiaSharp => 0xc71a4669 => 197
	i32 3340431453, ; 507: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 211
	i32 3345895724, ; 508: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 252
	i32 3346324047, ; 509: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 249
	i32 3357674450, ; 510: ru\Microsoft.Maui.Controls.resources => 0xc8220bd2 => 306
	i32 3358260929, ; 511: System.Text.Json => 0xc82afec1 => 138
	i32 3362336904, ; 512: Xamarin.AndroidX.Activity.Ktx => 0xc8693088 => 204
	i32 3362522851, ; 513: Xamarin.AndroidX.Core => 0xc86c06e3 => 220
	i32 3366347497, ; 514: Java.Interop => 0xc8a662e9 => 169
	i32 3374999561, ; 515: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 253
	i32 3381016424, ; 516: da\Microsoft.Maui.Controls.resources => 0xc9863768 => 285
	i32 3395150330, ; 517: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 102
	i32 3403906625, ; 518: System.Security.Cryptography.OpenSsl.dll => 0xcae37e41 => 124
	i32 3405233483, ; 519: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 224
	i32 3428513518, ; 520: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 177
	i32 3429136800, ; 521: System.Xml => 0xcc6479a0 => 164
	i32 3430777524, ; 522: netstandard => 0xcc7d82b4 => 168
	i32 3441283291, ; 523: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 227
	i32 3445260447, ; 524: System.Formats.Tar => 0xcd5a809f => 40
	i32 3452344032, ; 525: Microsoft.Maui.Controls.Compatibility.dll => 0xcdc696e0 => 184
	i32 3463511458, ; 526: hr/Microsoft.Maui.Controls.resources.dll => 0xce70fda2 => 293
	i32 3471940407, ; 527: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 19
	i32 3476120550, ; 528: Mono.Android => 0xcf3163e6 => 172
	i32 3479583265, ; 529: ru/Microsoft.Maui.Controls.resources.dll => 0xcf663a21 => 306
	i32 3484440000, ; 530: ro\Microsoft.Maui.Controls.resources => 0xcfb055c0 => 305
	i32 3485117614, ; 531: System.Text.Json.dll => 0xcfbaacae => 138
	i32 3486566296, ; 532: System.Transactions => 0xcfd0c798 => 151
	i32 3493954962, ; 533: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 216
	i32 3508241679, ; 534: NAudio.Asio => 0xd11b850f => 191
	i32 3509114376, ; 535: System.Xml.Linq => 0xd128d608 => 156
	i32 3515174580, ; 536: System.Security.dll => 0xd1854eb4 => 131
	i32 3530912306, ; 537: System.Configuration => 0xd2757232 => 21
	i32 3539954161, ; 538: System.Net.HttpListener => 0xd2ff69f1 => 66
	i32 3560100363, ; 539: System.Threading.Timer => 0xd432d20b => 148
	i32 3570554715, ; 540: System.IO.FileSystem.AccessControl => 0xd4d2575b => 48
	i32 3580758918, ; 541: zh-HK\Microsoft.Maui.Controls.resources => 0xd56e0b86 => 313
	i32 3597029428, ; 542: Xamarin.Android.Glide.GifDecoder.dll => 0xd6665034 => 202
	i32 3598340787, ; 543: System.Net.WebSockets.Client => 0xd67a52b3 => 80
	i32 3608333028, ; 544: Trener => 0xd712cae4 => 2
	i32 3608519521, ; 545: System.Linq.dll => 0xd715a361 => 62
	i32 3624195450, ; 546: System.Runtime.InteropServices.RuntimeInformation => 0xd804d57a => 107
	i32 3627220390, ; 547: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 251
	i32 3633644679, ; 548: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 206
	i32 3638274909, ; 549: System.IO.FileSystem.Primitives.dll => 0xd8dbab5d => 50
	i32 3641597786, ; 550: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 237
	i32 3643446276, ; 551: tr\Microsoft.Maui.Controls.resources => 0xd92a9404 => 310
	i32 3643854240, ; 552: Xamarin.AndroidX.Navigation.Fragment => 0xd930cda0 => 248
	i32 3645089577, ; 553: System.ComponentModel.DataAnnotations => 0xd943a729 => 16
	i32 3657292374, ; 554: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 176
	i32 3660523487, ; 555: System.Net.NetworkInformation => 0xda2f27df => 69
	i32 3660726404, ; 556: Plugin.Maui.Audio.dll => 0xda324084 => 196
	i32 3672681054, ; 557: Mono.Android.dll => 0xdae8aa5e => 172
	i32 3676670898, ; 558: Microsoft.Maui.Controls.HotReload.Forms => 0xdb258bb2 => 316
	i32 3682565725, ; 559: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 212
	i32 3684561358, ; 560: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 216
	i32 3697841164, ; 561: zh-Hant/Microsoft.Maui.Controls.resources.dll => 0xdc68940c => 315
	i32 3700866549, ; 562: System.Net.WebProxy.dll => 0xdc96bdf5 => 79
	i32 3706696989, ; 563: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 221
	i32 3716563718, ; 564: System.Runtime.Intrinsics => 0xdd864306 => 109
	i32 3718780102, ; 565: Xamarin.AndroidX.Annotation => 0xdda814c6 => 205
	i32 3724971120, ; 566: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 247
	i32 3732100267, ; 567: System.Net.NameResolution => 0xde7354ab => 68
	i32 3737834244, ; 568: System.Net.Http.Json.dll => 0xdecad304 => 64
	i32 3748608112, ; 569: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 198
	i32 3751444290, ; 570: System.Xml.XPath => 0xdf9a7f42 => 161
	i32 3786282454, ; 571: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 214
	i32 3792276235, ; 572: System.Collections.NonGeneric => 0xe2098b0b => 12
	i32 3800979733, ; 573: Microsoft.Maui.Controls.Compatibility => 0xe28e5915 => 184
	i32 3802395368, ; 574: System.Collections.Specialized.dll => 0xe2a3f2e8 => 13
	i32 3819260425, ; 575: System.Net.WebProxy => 0xe3a54a09 => 79
	i32 3823082795, ; 576: System.Security.Cryptography.dll => 0xe3df9d2b => 127
	i32 3829621856, ; 577: System.Numerics.dll => 0xe4436460 => 84
	i32 3831870545, ; 578: NAudio.WinMM.dll => 0xe465b451 => 195
	i32 3833826689, ; 579: NAudio.Core.dll => 0xe4838d81 => 192
	i32 3841636137, ; 580: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 178
	i32 3844307129, ; 581: System.Net.Mail.dll => 0xe52378b9 => 67
	i32 3849253459, ; 582: System.Runtime.InteropServices.dll => 0xe56ef253 => 108
	i32 3870376305, ; 583: System.Net.HttpListener.dll => 0xe6b14171 => 66
	i32 3873536506, ; 584: System.Security.Principal => 0xe6e179fa => 129
	i32 3875112723, ; 585: System.Security.Cryptography.Encoding.dll => 0xe6f98713 => 123
	i32 3885497537, ; 586: System.Net.WebHeaderCollection.dll => 0xe797fcc1 => 78
	i32 3885922214, ; 587: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 262
	i32 3887389151, ; 588: NAudio.Midi => 0xe7b4d9df => 193
	i32 3888767677, ; 589: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 252
	i32 3889960447, ; 590: zh-Hans/Microsoft.Maui.Controls.resources.dll => 0xe7dc15ff => 314
	i32 3896106733, ; 591: System.Collections.Concurrent.dll => 0xe839deed => 10
	i32 3896760992, ; 592: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 220
	i32 3901907137, ; 593: Microsoft.VisualBasic.Core.dll => 0xe89260c1 => 4
	i32 3920810846, ; 594: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 45
	i32 3921031405, ; 595: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 265
	i32 3928044579, ; 596: System.Xml.ReaderWriter => 0xea213423 => 157
	i32 3930554604, ; 597: System.Security.Principal.dll => 0xea4780ec => 129
	i32 3931092270, ; 598: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 250
	i32 3945713374, ; 599: System.Data.DataSetExtensions.dll => 0xeb2ecede => 25
	i32 3953953790, ; 600: System.Text.Encoding.CodePages => 0xebac8bfe => 134
	i32 3955647286, ; 601: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 208
	i32 3959773229, ; 602: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 239
	i32 3980434154, ; 603: th/Microsoft.Maui.Controls.resources.dll => 0xed409aea => 309
	i32 3987592930, ; 604: he/Microsoft.Maui.Controls.resources.dll => 0xedadd6e2 => 291
	i32 4003436829, ; 605: System.Diagnostics.Process.dll => 0xee9f991d => 30
	i32 4015948917, ; 606: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 207
	i32 4025784931, ; 607: System.Memory => 0xeff49a63 => 63
	i32 4046471985, ; 608: Microsoft.Maui.Controls.Xaml.dll => 0xf1304331 => 186
	i32 4054681211, ; 609: System.Reflection.Emit.ILGeneration => 0xf1ad867b => 91
	i32 4068434129, ; 610: System.Private.Xml.Linq.dll => 0xf27f60d1 => 88
	i32 4073602200, ; 611: System.Threading.dll => 0xf2ce3c98 => 149
	i32 4094352644, ; 612: Microsoft.Maui.Essentials.dll => 0xf40add04 => 188
	i32 4099507663, ; 613: System.Drawing.dll => 0xf45985cf => 37
	i32 4100113165, ; 614: System.Private.Uri => 0xf462c30d => 87
	i32 4101593132, ; 615: Xamarin.AndroidX.Emoji2 => 0xf479582c => 228
	i32 4102112229, ; 616: pt/Microsoft.Maui.Controls.resources.dll => 0xf48143e5 => 304
	i32 4125707920, ; 617: ms/Microsoft.Maui.Controls.resources.dll => 0xf5e94e90 => 299
	i32 4126470640, ; 618: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 177
	i32 4127667938, ; 619: System.IO.FileSystem.Watcher => 0xf60736e2 => 51
	i32 4130442656, ; 620: System.AppContext => 0xf6318da0 => 8
	i32 4147896353, ; 621: System.Reflection.Emit.ILGeneration.dll => 0xf73be021 => 91
	i32 4150914736, ; 622: uk\Microsoft.Maui.Controls.resources => 0xf769eeb0 => 311
	i32 4151237749, ; 623: System.Core => 0xf76edc75 => 23
	i32 4159265925, ; 624: System.Xml.XmlSerializer => 0xf7e95c85 => 163
	i32 4161255271, ; 625: System.Reflection.TypeExtensions => 0xf807b767 => 97
	i32 4164802419, ; 626: System.IO.FileSystem.Watcher.dll => 0xf83dd773 => 51
	i32 4181436372, ; 627: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 114
	i32 4182413190, ; 628: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 244
	i32 4182880526, ; 629: Microsoft.VisualStudio.DesignTools.MobileTapContracts => 0xf951b10e => 317
	i32 4185676441, ; 630: System.Security => 0xf97c5a99 => 131
	i32 4196529839, ; 631: System.Net.WebClient.dll => 0xfa21f6af => 77
	i32 4213026141, ; 632: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 198
	i32 4256097574, ; 633: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 221
	i32 4258378803, ; 634: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx => 0xfdd1b433 => 243
	i32 4260525087, ; 635: System.Buffers => 0xfdf2741f => 9
	i32 4271975918, ; 636: Microsoft.Maui.Controls.dll => 0xfea12dee => 185
	i32 4274976490, ; 637: System.Runtime.Numerics => 0xfecef6ea => 111
	i32 4292120959, ; 638: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 244
	i32 4294763496 ; 639: Xamarin.AndroidX.ExifInterface.dll => 0xfffce3e8 => 230
], align 4

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [640 x i32] [
	i32 69, ; 0
	i32 68, ; 1
	i32 109, ; 2
	i32 240, ; 3
	i32 274, ; 4
	i32 49, ; 5
	i32 81, ; 6
	i32 146, ; 7
	i32 31, ; 8
	i32 315, ; 9
	i32 125, ; 10
	i32 189, ; 11
	i32 103, ; 12
	i32 258, ; 13
	i32 108, ; 14
	i32 258, ; 15
	i32 140, ; 16
	i32 278, ; 17
	i32 78, ; 18
	i32 125, ; 19
	i32 194, ; 20
	i32 15, ; 21
	i32 214, ; 22
	i32 133, ; 23
	i32 260, ; 24
	i32 152, ; 25
	i32 312, ; 26
	i32 313, ; 27
	i32 20, ; 28
	i32 212, ; 29
	i32 28, ; 30
	i32 234, ; 31
	i32 3, ; 32
	i32 60, ; 33
	i32 43, ; 34
	i32 92, ; 35
	i32 217, ; 36
	i32 148, ; 37
	i32 236, ; 38
	i32 233, ; 39
	i32 284, ; 40
	i32 55, ; 41
	i32 70, ; 42
	i32 312, ; 43
	i32 203, ; 44
	i32 84, ; 45
	i32 297, ; 46
	i32 235, ; 47
	i32 296, ; 48
	i32 132, ; 49
	i32 56, ; 50
	i32 150, ; 51
	i32 75, ; 52
	i32 146, ; 53
	i32 63, ; 54
	i32 147, ; 55
	i32 319, ; 56
	i32 166, ; 57
	i32 308, ; 58
	i32 218, ; 59
	i32 14, ; 60
	i32 231, ; 61
	i32 126, ; 62
	i32 153, ; 63
	i32 114, ; 64
	i32 167, ; 65
	i32 165, ; 66
	i32 233, ; 67
	i32 246, ; 68
	i32 85, ; 69
	i32 295, ; 70
	i32 289, ; 71
	i32 183, ; 72
	i32 197, ; 73
	i32 151, ; 74
	i32 278, ; 75
	i32 61, ; 76
	i32 179, ; 77
	i32 52, ; 78
	i32 104, ; 79
	i32 115, ; 80
	i32 41, ; 81
	i32 271, ; 82
	i32 269, ; 83
	i32 121, ; 84
	i32 303, ; 85
	i32 53, ; 86
	i32 45, ; 87
	i32 120, ; 88
	i32 223, ; 89
	i32 301, ; 90
	i32 229, ; 91
	i32 82, ; 92
	i32 137, ; 93
	i32 265, ; 94
	i32 210, ; 95
	i32 10, ; 96
	i32 74, ; 97
	i32 283, ; 98
	i32 156, ; 99
	i32 280, ; 100
	i32 155, ; 101
	i32 93, ; 102
	i32 275, ; 103
	i32 46, ; 104
	i32 298, ; 105
	i32 286, ; 106
	i32 279, ; 107
	i32 110, ; 108
	i32 130, ; 109
	i32 27, ; 110
	i32 200, ; 111
	i32 73, ; 112
	i32 56, ; 113
	i32 47, ; 114
	i32 307, ; 115
	i32 182, ; 116
	i32 224, ; 117
	i32 24, ; 118
	i32 238, ; 119
	i32 87, ; 120
	i32 44, ; 121
	i32 161, ; 122
	i32 72, ; 123
	i32 251, ; 124
	i32 5, ; 125
	i32 43, ; 126
	i32 64, ; 127
	i32 18, ; 128
	i32 54, ; 129
	i32 310, ; 130
	i32 274, ; 131
	i32 106, ; 132
	i32 279, ; 133
	i32 272, ; 134
	i32 235, ; 135
	i32 35, ; 136
	i32 159, ; 137
	i32 86, ; 138
	i32 33, ; 139
	i32 14, ; 140
	i32 52, ; 141
	i32 57, ; 142
	i32 255, ; 143
	i32 37, ; 144
	i32 178, ; 145
	i32 285, ; 146
	i32 273, ; 147
	i32 208, ; 148
	i32 36, ; 149
	i32 59, ; 150
	i32 242, ; 151
	i32 174, ; 152
	i32 19, ; 153
	i32 276, ; 154
	i32 165, ; 155
	i32 298, ; 156
	i32 241, ; 157
	i32 181, ; 158
	i32 268, ; 159
	i32 304, ; 160
	i32 154, ; 161
	i32 264, ; 162
	i32 249, ; 163
	i32 302, ; 164
	i32 210, ; 165
	i32 30, ; 166
	i32 53, ; 167
	i32 300, ; 168
	i32 269, ; 169
	i32 7, ; 170
	i32 284, ; 171
	i32 259, ; 172
	i32 263, ; 173
	i32 215, ; 174
	i32 280, ; 175
	i32 207, ; 176
	i32 226, ; 177
	i32 0, ; 178
	i32 86, ; 179
	i32 268, ; 180
	i32 62, ; 181
	i32 113, ; 182
	i32 196, ; 183
	i32 58, ; 184
	i32 314, ; 185
	i32 255, ; 186
	i32 100, ; 187
	i32 21, ; 188
	i32 219, ; 189
	i32 112, ; 190
	i32 102, ; 191
	i32 103, ; 192
	i32 282, ; 193
	i32 105, ; 194
	i32 272, ; 195
	i32 72, ; 196
	i32 39, ; 197
	i32 33, ; 198
	i32 104, ; 199
	i32 74, ; 200
	i32 288, ; 201
	i32 11, ; 202
	i32 124, ; 203
	i32 47, ; 204
	i32 209, ; 205
	i32 183, ; 206
	i32 11, ; 207
	i32 44, ; 208
	i32 6, ; 209
	i32 192, ; 210
	i32 256, ; 211
	i32 292, ; 212
	i32 193, ; 213
	i32 287, ; 214
	i32 32, ; 215
	i32 139, ; 216
	i32 93, ; 217
	i32 1, ; 218
	i32 94, ; 219
	i32 307, ; 220
	i32 50, ; 221
	i32 142, ; 222
	i32 113, ; 223
	i32 141, ; 224
	i32 225, ; 225
	i32 116, ; 226
	i32 273, ; 227
	i32 158, ; 228
	i32 316, ; 229
	i32 77, ; 230
	i32 80, ; 231
	i32 245, ; 232
	i32 38, ; 233
	i32 267, ; 234
	i32 229, ; 235
	i32 222, ; 236
	i32 65, ; 237
	i32 139, ; 238
	i32 17, ; 239
	i32 190, ; 240
	i32 117, ; 241
	i32 261, ; 242
	i32 270, ; 243
	i32 217, ; 244
	i32 49, ; 245
	i32 71, ; 246
	i32 81, ; 247
	i32 127, ; 248
	i32 95, ; 249
	i32 122, ; 250
	i32 277, ; 251
	i32 28, ; 252
	i32 238, ; 253
	i32 98, ; 254
	i32 29, ; 255
	i32 213, ; 256
	i32 305, ; 257
	i32 283, ; 258
	i32 150, ; 259
	i32 170, ; 260
	i32 6, ; 261
	i32 99, ; 262
	i32 34, ; 263
	i32 94, ; 264
	i32 260, ; 265
	i32 179, ; 266
	i32 23, ; 267
	i32 42, ; 268
	i32 171, ; 269
	i32 299, ; 270
	i32 231, ; 271
	i32 291, ; 272
	i32 245, ; 273
	i32 276, ; 274
	i32 270, ; 275
	i32 250, ; 276
	i32 4, ; 277
	i32 135, ; 278
	i32 112, ; 279
	i32 318, ; 280
	i32 180, ; 281
	i32 311, ; 282
	i32 200, ; 283
	i32 308, ; 284
	i32 59, ; 285
	i32 96, ; 286
	i32 290, ; 287
	i32 40, ; 288
	i32 211, ; 289
	i32 318, ; 290
	i32 27, ; 291
	i32 95, ; 292
	i32 90, ; 293
	i32 100, ; 294
	i32 12, ; 295
	i32 88, ; 296
	i32 101, ; 297
	i32 257, ; 298
	i32 175, ; 299
	i32 277, ; 300
	i32 202, ; 301
	i32 287, ; 302
	i32 9, ; 303
	i32 242, ; 304
	i32 282, ; 305
	i32 199, ; 306
	i32 89, ; 307
	i32 237, ; 308
	i32 155, ; 309
	i32 286, ; 310
	i32 34, ; 311
	i32 117, ; 312
	i32 83, ; 313
	i32 22, ; 314
	i32 13, ; 315
	i32 163, ; 316
	i32 5, ; 317
	i32 187, ; 318
	i32 294, ; 319
	i32 182, ; 320
	i32 180, ; 321
	i32 85, ; 322
	i32 190, ; 323
	i32 281, ; 324
	i32 65, ; 325
	i32 296, ; 326
	i32 264, ; 327
	i32 144, ; 328
	i32 246, ; 329
	i32 158, ; 330
	i32 42, ; 331
	i32 118, ; 332
	i32 176, ; 333
	i32 201, ; 334
	i32 290, ; 335
	i32 253, ; 336
	i32 132, ; 337
	i32 76, ; 338
	i32 67, ; 339
	i32 300, ; 340
	i32 173, ; 341
	i32 205, ; 342
	i32 144, ; 343
	i32 107, ; 344
	i32 152, ; 345
	i32 71, ; 346
	i32 157, ; 347
	i32 175, ; 348
	i32 122, ; 349
	i32 128, ; 350
	i32 194, ; 351
	i32 295, ; 352
	i32 153, ; 353
	i32 228, ; 354
	i32 317, ; 355
	i32 142, ; 356
	i32 215, ; 357
	i32 292, ; 358
	i32 22, ; 359
	i32 16, ; 360
	i32 136, ; 361
	i32 76, ; 362
	i32 60, ; 363
	i32 218, ; 364
	i32 168, ; 365
	i32 169, ; 366
	i32 0, ; 367
	i32 185, ; 368
	i32 17, ; 369
	i32 75, ; 370
	i32 8, ; 371
	i32 25, ; 372
	i32 240, ; 373
	i32 199, ; 374
	i32 92, ; 375
	i32 293, ; 376
	i32 3, ; 377
	i32 137, ; 378
	i32 241, ; 379
	i32 263, ; 380
	i32 135, ; 381
	i32 70, ; 382
	i32 147, ; 383
	i32 302, ; 384
	i32 281, ; 385
	i32 232, ; 386
	i32 181, ; 387
	i32 89, ; 388
	i32 97, ; 389
	i32 222, ; 390
	i32 227, ; 391
	i32 297, ; 392
	i32 32, ; 393
	i32 46, ; 394
	i32 236, ; 395
	i32 201, ; 396
	i32 110, ; 397
	i32 159, ; 398
	i32 36, ; 399
	i32 24, ; 400
	i32 115, ; 401
	i32 58, ; 402
	i32 261, ; 403
	i32 145, ; 404
	i32 119, ; 405
	i32 121, ; 406
	i32 111, ; 407
	i32 203, ; 408
	i32 140, ; 409
	i32 209, ; 410
	i32 55, ; 411
	i32 106, ; 412
	i32 303, ; 413
	i32 186, ; 414
	i32 187, ; 415
	i32 134, ; 416
	i32 275, ; 417
	i32 266, ; 418
	i32 254, ; 419
	i32 309, ; 420
	i32 232, ; 421
	i32 189, ; 422
	i32 160, ; 423
	i32 288, ; 424
	i32 219, ; 425
	i32 164, ; 426
	i32 133, ; 427
	i32 254, ; 428
	i32 162, ; 429
	i32 301, ; 430
	i32 243, ; 431
	i32 141, ; 432
	i32 266, ; 433
	i32 262, ; 434
	i32 170, ; 435
	i32 188, ; 436
	i32 204, ; 437
	i32 271, ; 438
	i32 41, ; 439
	i32 230, ; 440
	i32 82, ; 441
	i32 57, ; 442
	i32 38, ; 443
	i32 98, ; 444
	i32 167, ; 445
	i32 173, ; 446
	i32 267, ; 447
	i32 1, ; 448
	i32 83, ; 449
	i32 206, ; 450
	i32 99, ; 451
	i32 31, ; 452
	i32 160, ; 453
	i32 20, ; 454
	i32 128, ; 455
	i32 120, ; 456
	i32 226, ; 457
	i32 257, ; 458
	i32 191, ; 459
	i32 239, ; 460
	i32 259, ; 461
	i32 166, ; 462
	i32 234, ; 463
	i32 319, ; 464
	i32 256, ; 465
	i32 247, ; 466
	i32 171, ; 467
	i32 18, ; 468
	i32 195, ; 469
	i32 145, ; 470
	i32 294, ; 471
	i32 2, ; 472
	i32 126, ; 473
	i32 119, ; 474
	i32 39, ; 475
	i32 116, ; 476
	i32 48, ; 477
	i32 143, ; 478
	i32 118, ; 479
	i32 35, ; 480
	i32 174, ; 481
	i32 96, ; 482
	i32 54, ; 483
	i32 248, ; 484
	i32 130, ; 485
	i32 154, ; 486
	i32 26, ; 487
	i32 162, ; 488
	i32 225, ; 489
	i32 149, ; 490
	i32 105, ; 491
	i32 90, ; 492
	i32 213, ; 493
	i32 61, ; 494
	i32 143, ; 495
	i32 101, ; 496
	i32 7, ; 497
	i32 15, ; 498
	i32 123, ; 499
	i32 136, ; 500
	i32 29, ; 501
	i32 289, ; 502
	i32 73, ; 503
	i32 223, ; 504
	i32 26, ; 505
	i32 197, ; 506
	i32 211, ; 507
	i32 252, ; 508
	i32 249, ; 509
	i32 306, ; 510
	i32 138, ; 511
	i32 204, ; 512
	i32 220, ; 513
	i32 169, ; 514
	i32 253, ; 515
	i32 285, ; 516
	i32 102, ; 517
	i32 124, ; 518
	i32 224, ; 519
	i32 177, ; 520
	i32 164, ; 521
	i32 168, ; 522
	i32 227, ; 523
	i32 40, ; 524
	i32 184, ; 525
	i32 293, ; 526
	i32 19, ; 527
	i32 172, ; 528
	i32 306, ; 529
	i32 305, ; 530
	i32 138, ; 531
	i32 151, ; 532
	i32 216, ; 533
	i32 191, ; 534
	i32 156, ; 535
	i32 131, ; 536
	i32 21, ; 537
	i32 66, ; 538
	i32 148, ; 539
	i32 48, ; 540
	i32 313, ; 541
	i32 202, ; 542
	i32 80, ; 543
	i32 2, ; 544
	i32 62, ; 545
	i32 107, ; 546
	i32 251, ; 547
	i32 206, ; 548
	i32 50, ; 549
	i32 237, ; 550
	i32 310, ; 551
	i32 248, ; 552
	i32 16, ; 553
	i32 176, ; 554
	i32 69, ; 555
	i32 196, ; 556
	i32 172, ; 557
	i32 316, ; 558
	i32 212, ; 559
	i32 216, ; 560
	i32 315, ; 561
	i32 79, ; 562
	i32 221, ; 563
	i32 109, ; 564
	i32 205, ; 565
	i32 247, ; 566
	i32 68, ; 567
	i32 64, ; 568
	i32 198, ; 569
	i32 161, ; 570
	i32 214, ; 571
	i32 12, ; 572
	i32 184, ; 573
	i32 13, ; 574
	i32 79, ; 575
	i32 127, ; 576
	i32 84, ; 577
	i32 195, ; 578
	i32 192, ; 579
	i32 178, ; 580
	i32 67, ; 581
	i32 108, ; 582
	i32 66, ; 583
	i32 129, ; 584
	i32 123, ; 585
	i32 78, ; 586
	i32 262, ; 587
	i32 193, ; 588
	i32 252, ; 589
	i32 314, ; 590
	i32 10, ; 591
	i32 220, ; 592
	i32 4, ; 593
	i32 45, ; 594
	i32 265, ; 595
	i32 157, ; 596
	i32 129, ; 597
	i32 250, ; 598
	i32 25, ; 599
	i32 134, ; 600
	i32 208, ; 601
	i32 239, ; 602
	i32 309, ; 603
	i32 291, ; 604
	i32 30, ; 605
	i32 207, ; 606
	i32 63, ; 607
	i32 186, ; 608
	i32 91, ; 609
	i32 88, ; 610
	i32 149, ; 611
	i32 188, ; 612
	i32 37, ; 613
	i32 87, ; 614
	i32 228, ; 615
	i32 304, ; 616
	i32 299, ; 617
	i32 177, ; 618
	i32 51, ; 619
	i32 8, ; 620
	i32 91, ; 621
	i32 311, ; 622
	i32 23, ; 623
	i32 163, ; 624
	i32 97, ; 625
	i32 51, ; 626
	i32 114, ; 627
	i32 244, ; 628
	i32 317, ; 629
	i32 131, ; 630
	i32 77, ; 631
	i32 198, ; 632
	i32 221, ; 633
	i32 243, ; 634
	i32 9, ; 635
	i32 185, ; 636
	i32 111, ; 637
	i32 244, ; 638
	i32 230 ; 639
], align 4

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 4

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 4

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 4

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 4, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 1

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" }

; Metadata
!llvm.module.flags = !{!0, !1, !7}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.4xx @ a8cd27e430e55df3e3c1e3a43d35c11d9512a2db"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"NumRegisterParameters", i32 0}
