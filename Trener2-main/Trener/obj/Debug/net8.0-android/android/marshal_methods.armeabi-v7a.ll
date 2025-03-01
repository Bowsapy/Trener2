; ModuleID = 'marshal_methods.armeabi-v7a.ll'
source_filename = "marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [320 x ptr] zeroinitializer, align 4

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [634 x i32] [
	i32 2616222, ; 0: System.Net.NetworkInformation.dll => 0x27eb9e => 70
	i32 10166715, ; 1: System.Net.NameResolution.dll => 0x9b21bb => 69
	i32 15721112, ; 2: System.Runtime.Intrinsics.dll => 0xefe298 => 110
	i32 32687329, ; 3: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 240
	i32 34715100, ; 4: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 274
	i32 34839235, ; 5: System.IO.FileSystem.DriveInfo => 0x2139ac3 => 50
	i32 39485524, ; 6: System.Net.WebSockets.dll => 0x25a8054 => 82
	i32 42639949, ; 7: System.Threading.Thread => 0x28aa24d => 147
	i32 66541672, ; 8: System.Diagnostics.StackTrace => 0x3f75868 => 32
	i32 67008169, ; 9: zh-Hant\Microsoft.Maui.Controls.resources => 0x3fe76a9 => 315
	i32 68219467, ; 10: System.Security.Cryptography.Primitives => 0x410f24b => 126
	i32 72070932, ; 11: Microsoft.Maui.Graphics.dll => 0x44bb714 => 190
	i32 82292897, ; 12: System.Runtime.CompilerServices.VisualC.dll => 0x4e7b0a1 => 104
	i32 101534019, ; 13: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 258
	i32 117431740, ; 14: System.Runtime.InteropServices => 0x6ffddbc => 109
	i32 120558881, ; 15: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 258
	i32 122350210, ; 16: System.Threading.Channels.dll => 0x74aea82 => 141
	i32 134690465, ; 17: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 278
	i32 142721839, ; 18: System.Net.WebHeaderCollection => 0x881c32f => 79
	i32 149972175, ; 19: System.Security.Cryptography.Primitives.dll => 0x8f064cf => 126
	i32 151607338, ; 20: NAudio.Wasapi => 0x909582a => 195
	i32 159306688, ; 21: System.ComponentModel.Annotations => 0x97ed3c0 => 15
	i32 165246403, ; 22: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 214
	i32 176265551, ; 23: System.ServiceProcess => 0xa81994f => 134
	i32 182336117, ; 24: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 260
	i32 184328833, ; 25: System.ValueTuple.dll => 0xafca281 => 153
	i32 195452805, ; 26: vi/Microsoft.Maui.Controls.resources.dll => 0xba65f85 => 312
	i32 199333315, ; 27: zh-HK/Microsoft.Maui.Controls.resources.dll => 0xbe195c3 => 313
	i32 205061960, ; 28: System.ComponentModel => 0xc38ff48 => 20
	i32 209399409, ; 29: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 212
	i32 220171995, ; 30: System.Diagnostics.Debug => 0xd1f8edb => 28
	i32 230216969, ; 31: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 234
	i32 230752869, ; 32: Microsoft.CSharp.dll => 0xdc10265 => 3
	i32 231409092, ; 33: System.Linq.Parallel => 0xdcb05c4 => 61
	i32 231814094, ; 34: System.Globalization => 0xdd133ce => 44
	i32 246610117, ; 35: System.Reflection.Emit.Lightweight => 0xeb2f8c5 => 93
	i32 261689757, ; 36: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 217
	i32 276479776, ; 37: System.Threading.Timer.dll => 0x107abf20 => 149
	i32 278686392, ; 38: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 236
	i32 280482487, ; 39: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 233
	i32 280992041, ; 40: cs/Microsoft.Maui.Controls.resources.dll => 0x10bf9929 => 284
	i32 291076382, ; 41: System.IO.Pipes.AccessControl.dll => 0x1159791e => 56
	i32 298918909, ; 42: System.Net.Ping.dll => 0x11d123fd => 71
	i32 317674968, ; 43: vi\Microsoft.Maui.Controls.resources => 0x12ef55d8 => 312
	i32 318968648, ; 44: Xamarin.AndroidX.Activity.dll => 0x13031348 => 203
	i32 321597661, ; 45: System.Numerics => 0x132b30dd => 85
	i32 336156722, ; 46: ja/Microsoft.Maui.Controls.resources.dll => 0x14095832 => 297
	i32 342366114, ; 47: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 235
	i32 356389973, ; 48: it/Microsoft.Maui.Controls.resources.dll => 0x153e1455 => 296
	i32 360082299, ; 49: System.ServiceModel.Web => 0x15766b7b => 133
	i32 367780167, ; 50: System.IO.Pipes => 0x15ebe147 => 57
	i32 374914964, ; 51: System.Transactions.Local => 0x1658bf94 => 151
	i32 375677976, ; 52: System.Net.ServicePoint.dll => 0x16646418 => 76
	i32 379916513, ; 53: System.Threading.Thread.dll => 0x16a510e1 => 147
	i32 385762202, ; 54: System.Memory.dll => 0x16fe439a => 64
	i32 392610295, ; 55: System.Threading.ThreadPool.dll => 0x1766c1f7 => 148
	i32 395744057, ; 56: _Microsoft.Android.Resource.Designer => 0x17969339 => 316
	i32 403441872, ; 57: WindowsBase => 0x180c08d0 => 167
	i32 435591531, ; 58: sv/Microsoft.Maui.Controls.resources.dll => 0x19f6996b => 308
	i32 441335492, ; 59: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 218
	i32 442565967, ; 60: System.Collections => 0x1a61054f => 14
	i32 450948140, ; 61: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 231
	i32 451504562, ; 62: System.Security.Cryptography.X509Certificates => 0x1ae969b2 => 127
	i32 456227837, ; 63: System.Web.HttpUtility.dll => 0x1b317bfd => 154
	i32 459347974, ; 64: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 115
	i32 465846621, ; 65: mscorlib => 0x1bc4415d => 168
	i32 469710990, ; 66: System.dll => 0x1bff388e => 166
	i32 476646585, ; 67: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 233
	i32 486930444, ; 68: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 246
	i32 498788369, ; 69: System.ObjectModel => 0x1dbae811 => 86
	i32 500358224, ; 70: id/Microsoft.Maui.Controls.resources.dll => 0x1dd2dc50 => 295
	i32 503918385, ; 71: fi/Microsoft.Maui.Controls.resources.dll => 0x1e092f31 => 289
	i32 513247710, ; 72: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 184
	i32 525008092, ; 73: SkiaSharp.dll => 0x1f4afcdc => 198
	i32 526420162, ; 74: System.Transactions.dll => 0x1f6088c2 => 152
	i32 527452488, ; 75: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 278
	i32 530272170, ; 76: System.Linq.Queryable => 0x1f9b4faa => 62
	i32 539058512, ; 77: Microsoft.Extensions.Logging => 0x20216150 => 180
	i32 540030774, ; 78: System.IO.FileSystem.dll => 0x20303736 => 53
	i32 545304856, ; 79: System.Runtime.Extensions => 0x2080b118 => 105
	i32 546455878, ; 80: System.Runtime.Serialization.Xml => 0x20924146 => 116
	i32 549171840, ; 81: System.Globalization.Calendars => 0x20bbb280 => 42
	i32 557405415, ; 82: Jsr305Binding => 0x213954e7 => 271
	i32 569601784, ; 83: Xamarin.AndroidX.Window.Extensions.Core.Core => 0x21f36ef8 => 269
	i32 577335427, ; 84: System.Security.Cryptography.Cng => 0x22697083 => 122
	i32 592146354, ; 85: pt-BR/Microsoft.Maui.Controls.resources.dll => 0x234b6fb2 => 303
	i32 601371474, ; 86: System.IO.IsolatedStorage.dll => 0x23d83352 => 54
	i32 605376203, ; 87: System.IO.Compression.FileSystem => 0x24154ecb => 46
	i32 613668793, ; 88: System.Security.Cryptography.Algorithms => 0x2493d7b9 => 121
	i32 627609679, ; 89: Xamarin.AndroidX.CustomView => 0x2568904f => 223
	i32 627931235, ; 90: nl\Microsoft.Maui.Controls.resources => 0x256d7863 => 301
	i32 639843206, ; 91: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 229
	i32 643868501, ; 92: System.Net => 0x2660a755 => 83
	i32 662205335, ; 93: System.Text.Encodings.Web.dll => 0x27787397 => 138
	i32 663517072, ; 94: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 265
	i32 666292255, ; 95: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 210
	i32 672442732, ; 96: System.Collections.Concurrent => 0x2814a96c => 10
	i32 683518922, ; 97: System.Net.Security => 0x28bdabca => 75
	i32 688181140, ; 98: ca/Microsoft.Maui.Controls.resources.dll => 0x2904cf94 => 283
	i32 690569205, ; 99: System.Xml.Linq.dll => 0x29293ff5 => 157
	i32 691348768, ; 100: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 280
	i32 693804605, ; 101: System.Windows => 0x295a9e3d => 156
	i32 699345723, ; 102: System.Reflection.Emit => 0x29af2b3b => 94
	i32 700284507, ; 103: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 275
	i32 700358131, ; 104: System.IO.Compression.ZipFile => 0x29be9df3 => 47
	i32 706645707, ; 105: ko/Microsoft.Maui.Controls.resources.dll => 0x2a1e8ecb => 298
	i32 709557578, ; 106: de/Microsoft.Maui.Controls.resources.dll => 0x2a4afd4a => 286
	i32 720511267, ; 107: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 279
	i32 722857257, ; 108: System.Runtime.Loader.dll => 0x2b15ed29 => 111
	i32 735137430, ; 109: System.Security.SecureString.dll => 0x2bd14e96 => 131
	i32 752232764, ; 110: System.Diagnostics.Contracts.dll => 0x2cd6293c => 27
	i32 755313932, ; 111: Xamarin.Android.Glide.Annotations.dll => 0x2d052d0c => 200
	i32 759454413, ; 112: System.Net.Requests => 0x2d445acd => 74
	i32 762598435, ; 113: System.IO.Pipes.dll => 0x2d745423 => 57
	i32 775507847, ; 114: System.IO.Compression => 0x2e394f87 => 48
	i32 777317022, ; 115: sk\Microsoft.Maui.Controls.resources => 0x2e54ea9e => 307
	i32 789151979, ; 116: Microsoft.Extensions.Options => 0x2f0980eb => 183
	i32 790371945, ; 117: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 224
	i32 804715423, ; 118: System.Data.Common => 0x2ff6fb9f => 24
	i32 807930345, ; 119: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx.dll => 0x302809e9 => 238
	i32 823281589, ; 120: System.Private.Uri.dll => 0x311247b5 => 88
	i32 830298997, ; 121: System.IO.Compression.Brotli => 0x317d5b75 => 45
	i32 832635846, ; 122: System.Xml.XPath.dll => 0x31a103c6 => 162
	i32 834051424, ; 123: System.Net.Quic => 0x31b69d60 => 73
	i32 843511501, ; 124: Xamarin.AndroidX.Print => 0x3246f6cd => 251
	i32 873119928, ; 125: Microsoft.VisualBasic => 0x340ac0b8 => 5
	i32 877678880, ; 126: System.Globalization.dll => 0x34505120 => 44
	i32 878954865, ; 127: System.Net.Http.Json => 0x3463c971 => 65
	i32 904024072, ; 128: System.ComponentModel.Primitives.dll => 0x35e25008 => 18
	i32 911108515, ; 129: System.IO.MemoryMappedFiles.dll => 0x364e69a3 => 55
	i32 926902833, ; 130: tr/Microsoft.Maui.Controls.resources.dll => 0x373f6a31 => 310
	i32 928116545, ; 131: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 274
	i32 952186615, ; 132: System.Runtime.InteropServices.JavaScript.dll => 0x38c136f7 => 107
	i32 956575887, ; 133: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 279
	i32 966729478, ; 134: Xamarin.Google.Crypto.Tink.Android => 0x399f1f06 => 272
	i32 967690846, ; 135: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 235
	i32 975236339, ; 136: System.Diagnostics.Tracing => 0x3a20ecf3 => 36
	i32 975874589, ; 137: System.Xml.XDocument => 0x3a2aaa1d => 160
	i32 986514023, ; 138: System.Private.DataContractSerialization.dll => 0x3acd0267 => 87
	i32 987214855, ; 139: System.Diagnostics.Tools => 0x3ad7b407 => 34
	i32 992768348, ; 140: System.Collections.dll => 0x3b2c715c => 14
	i32 994442037, ; 141: System.IO.FileSystem => 0x3b45fb35 => 53
	i32 1001831731, ; 142: System.IO.UnmanagedMemoryStream.dll => 0x3bb6bd33 => 58
	i32 1012816738, ; 143: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 255
	i32 1019214401, ; 144: System.Drawing => 0x3cbffa41 => 38
	i32 1028951442, ; 145: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 179
	i32 1029334545, ; 146: da/Microsoft.Maui.Controls.resources.dll => 0x3d5a6611 => 285
	i32 1031528504, ; 147: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 273
	i32 1035644815, ; 148: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 208
	i32 1036536393, ; 149: System.Drawing.Primitives.dll => 0x3dc84a49 => 37
	i32 1044663988, ; 150: System.Linq.Expressions.dll => 0x3e444eb4 => 60
	i32 1052210849, ; 151: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 242
	i32 1067306892, ; 152: GoogleGson => 0x3f9dcf8c => 175
	i32 1082857460, ; 153: System.ComponentModel.TypeConverter => 0x408b17f4 => 19
	i32 1084122840, ; 154: Xamarin.Kotlin.StdLib => 0x409e66d8 => 276
	i32 1098259244, ; 155: System => 0x41761b2c => 166
	i32 1118262833, ; 156: ko\Microsoft.Maui.Controls.resources => 0x42a75631 => 298
	i32 1121599056, ; 157: Xamarin.AndroidX.Lifecycle.Runtime.Ktx.dll => 0x42da3e50 => 241
	i32 1127624469, ; 158: Microsoft.Extensions.Logging.Debug => 0x43362f15 => 182
	i32 1149092582, ; 159: Xamarin.AndroidX.Window => 0x447dc2e6 => 268
	i32 1168523401, ; 160: pt\Microsoft.Maui.Controls.resources => 0x45a64089 => 304
	i32 1170634674, ; 161: System.Web.dll => 0x45c677b2 => 155
	i32 1175144683, ; 162: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 264
	i32 1178241025, ; 163: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 249
	i32 1203215381, ; 164: pl/Microsoft.Maui.Controls.resources.dll => 0x47b79c15 => 302
	i32 1204270330, ; 165: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 210
	i32 1208641965, ; 166: System.Diagnostics.Process => 0x480a69ad => 31
	i32 1219128291, ; 167: System.IO.IsolatedStorage => 0x48aa6be3 => 54
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
	i32 1309188875, ; 179: System.Private.DataContractSerialization => 0x4e08a30b => 87
	i32 1322716291, ; 180: Xamarin.AndroidX.Window.dll => 0x4ed70c83 => 268
	i32 1324164729, ; 181: System.Linq => 0x4eed2679 => 63
	i32 1335329327, ; 182: System.Runtime.Serialization.Json.dll => 0x4f97822f => 114
	i32 1347751866, ; 183: Plugin.Maui.Audio => 0x50550fba => 197
	i32 1364015309, ; 184: System.IO => 0x514d38cd => 59
	i32 1373134921, ; 185: zh-Hans\Microsoft.Maui.Controls.resources => 0x51d86049 => 314
	i32 1376866003, ; 186: Xamarin.AndroidX.SavedState => 0x52114ed3 => 255
	i32 1379779777, ; 187: System.Resources.ResourceManager => 0x523dc4c1 => 101
	i32 1402170036, ; 188: System.Configuration.dll => 0x53936ab4 => 21
	i32 1406073936, ; 189: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 219
	i32 1408764838, ; 190: System.Runtime.Serialization.Formatters.dll => 0x53f80ba6 => 113
	i32 1411638395, ; 191: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 103
	i32 1422545099, ; 192: System.Runtime.CompilerServices.VisualC => 0x54ca50cb => 104
	i32 1430672901, ; 193: ar\Microsoft.Maui.Controls.resources => 0x55465605 => 282
	i32 1434145427, ; 194: System.Runtime.Handles => 0x557b5293 => 106
	i32 1435222561, ; 195: Xamarin.Google.Crypto.Tink.Android.dll => 0x558bc221 => 272
	i32 1439761251, ; 196: System.Net.Quic.dll => 0x55d10363 => 73
	i32 1452070440, ; 197: System.Formats.Asn1.dll => 0x568cd628 => 40
	i32 1453312822, ; 198: System.Diagnostics.Tools.dll => 0x569fcb36 => 34
	i32 1457743152, ; 199: System.Runtime.Extensions.dll => 0x56e36530 => 105
	i32 1458022317, ; 200: System.Net.Security.dll => 0x56e7a7ad => 75
	i32 1461004990, ; 201: es\Microsoft.Maui.Controls.resources => 0x57152abe => 288
	i32 1461234159, ; 202: System.Collections.Immutable.dll => 0x5718a9ef => 11
	i32 1461719063, ; 203: System.Security.Cryptography.OpenSsl => 0x57201017 => 125
	i32 1462112819, ; 204: System.IO.Compression.dll => 0x57261233 => 48
	i32 1469204771, ; 205: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 209
	i32 1470490898, ; 206: Microsoft.Extensions.Primitives => 0x57a5e912 => 184
	i32 1479771757, ; 207: System.Collections.Immutable => 0x5833866d => 11
	i32 1480492111, ; 208: System.IO.Compression.Brotli.dll => 0x583e844f => 45
	i32 1487239319, ; 209: Microsoft.Win32.Primitives => 0x58a57897 => 6
	i32 1489956495, ; 210: NAudio.Core => 0x58ceee8f => 193
	i32 1490025113, ; 211: Xamarin.AndroidX.SavedState.SavedState.Ktx.dll => 0x58cffa99 => 256
	i32 1493001747, ; 212: hi/Microsoft.Maui.Controls.resources.dll => 0x58fd6613 => 292
	i32 1495870163, ; 213: NAudio.Midi.dll => 0x59292ad3 => 194
	i32 1514721132, ; 214: el/Microsoft.Maui.Controls.resources.dll => 0x5a48cf6c => 287
	i32 1536373174, ; 215: System.Diagnostics.TextWriterTraceListener => 0x5b9331b6 => 33
	i32 1543031311, ; 216: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 140
	i32 1543355203, ; 217: System.Reflection.Emit.dll => 0x5bfdbb43 => 94
	i32 1543663015, ; 218: en\Trener.resources => 0x5c026da7 => 1
	i32 1550322496, ; 219: System.Reflection.Extensions.dll => 0x5c680b40 => 95
	i32 1551623176, ; 220: sk/Microsoft.Maui.Controls.resources.dll => 0x5c7be408 => 307
	i32 1565862583, ; 221: System.IO.FileSystem.Primitives => 0x5d552ab7 => 51
	i32 1566207040, ; 222: System.Threading.Tasks.Dataflow.dll => 0x5d5a6c40 => 143
	i32 1573704789, ; 223: System.Runtime.Serialization.Json => 0x5dccd455 => 114
	i32 1580037396, ; 224: System.Threading.Overlapped => 0x5e2d7514 => 142
	i32 1582372066, ; 225: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 225
	i32 1592978981, ; 226: System.Runtime.Serialization.dll => 0x5ef2ee25 => 117
	i32 1597949149, ; 227: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 273
	i32 1601112923, ; 228: System.Xml.Serialization => 0x5f6f0b5b => 159
	i32 1604827217, ; 229: System.Net.WebClient => 0x5fa7b851 => 78
	i32 1618516317, ; 230: System.Net.WebSockets.Client.dll => 0x6078995d => 81
	i32 1622152042, ; 231: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 245
	i32 1622358360, ; 232: System.Dynamic.Runtime => 0x60b33958 => 39
	i32 1624863272, ; 233: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 267
	i32 1635184631, ; 234: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 229
	i32 1636350590, ; 235: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 222
	i32 1639515021, ; 236: System.Net.Http.dll => 0x61b9038d => 66
	i32 1639986890, ; 237: System.Text.RegularExpressions => 0x61c036ca => 140
	i32 1641389582, ; 238: System.ComponentModel.EventBasedAsync.dll => 0x61d59e0e => 17
	i32 1654915987, ; 239: NAudio => 0x62a40393 => 191
	i32 1657153582, ; 240: System.Runtime => 0x62c6282e => 118
	i32 1658241508, ; 241: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 261
	i32 1658251792, ; 242: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 270
	i32 1670060433, ; 243: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 217
	i32 1675553242, ; 244: System.IO.FileSystem.DriveInfo.dll => 0x63dee9da => 50
	i32 1677501392, ; 245: System.Net.Primitives.dll => 0x63fca3d0 => 72
	i32 1678508291, ; 246: System.Net.WebSockets => 0x640c0103 => 82
	i32 1679769178, ; 247: System.Security.Cryptography => 0x641f3e5a => 128
	i32 1691477237, ; 248: System.Reflection.Metadata => 0x64d1e4f5 => 96
	i32 1696967625, ; 249: System.Security.Cryptography.Csp => 0x6525abc9 => 123
	i32 1698840827, ; 250: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 277
	i32 1701541528, ; 251: System.Diagnostics.Debug.dll => 0x656b7698 => 28
	i32 1720223769, ; 252: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx => 0x66888819 => 238
	i32 1726116996, ; 253: System.Reflection.dll => 0x66e27484 => 99
	i32 1728033016, ; 254: System.Diagnostics.FileVersionInfo.dll => 0x66ffb0f8 => 30
	i32 1729485958, ; 255: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 213
	i32 1736233607, ; 256: ro/Microsoft.Maui.Controls.resources.dll => 0x677cd287 => 305
	i32 1743415430, ; 257: ca\Microsoft.Maui.Controls.resources => 0x67ea6886 => 283
	i32 1744735666, ; 258: System.Transactions.Local.dll => 0x67fe8db2 => 151
	i32 1746316138, ; 259: Mono.Android.Export => 0x6816ab6a => 171
	i32 1750313021, ; 260: Microsoft.Win32.Primitives.dll => 0x6853a83d => 6
	i32 1758240030, ; 261: System.Resources.Reader.dll => 0x68cc9d1e => 100
	i32 1763938596, ; 262: System.Diagnostics.TraceSource.dll => 0x69239124 => 35
	i32 1765942094, ; 263: System.Reflection.Extensions => 0x6942234e => 95
	i32 1766324549, ; 264: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 260
	i32 1770582343, ; 265: Microsoft.Extensions.Logging.dll => 0x6988f147 => 180
	i32 1776026572, ; 266: System.Core.dll => 0x69dc03cc => 23
	i32 1777075843, ; 267: System.Globalization.Extensions.dll => 0x69ec0683 => 43
	i32 1780572499, ; 268: Mono.Android.Runtime.dll => 0x6a216153 => 172
	i32 1782862114, ; 269: ms\Microsoft.Maui.Controls.resources => 0x6a445122 => 299
	i32 1788241197, ; 270: Xamarin.AndroidX.Fragment => 0x6a96652d => 231
	i32 1793755602, ; 271: he\Microsoft.Maui.Controls.resources => 0x6aea89d2 => 291
	i32 1808609942, ; 272: Xamarin.AndroidX.Loader => 0x6bcd3296 => 245
	i32 1813058853, ; 273: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 276
	i32 1813201214, ; 274: Xamarin.Google.Android.Material => 0x6c13413e => 270
	i32 1818569960, ; 275: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 250
	i32 1818787751, ; 276: Microsoft.VisualBasic.Core => 0x6c687fa7 => 4
	i32 1824175904, ; 277: System.Text.Encoding.Extensions => 0x6cbab720 => 136
	i32 1824722060, ; 278: System.Runtime.Serialization.Formatters => 0x6cc30c8c => 113
	i32 1828688058, ; 279: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 181
	i32 1842015223, ; 280: uk/Microsoft.Maui.Controls.resources.dll => 0x6dcaebf7 => 311
	i32 1847515442, ; 281: Xamarin.Android.Glide.Annotations => 0x6e1ed932 => 200
	i32 1853025655, ; 282: sv\Microsoft.Maui.Controls.resources => 0x6e72ed77 => 308
	i32 1858542181, ; 283: System.Linq.Expressions => 0x6ec71a65 => 60
	i32 1870277092, ; 284: System.Reflection.Primitives => 0x6f7a29e4 => 97
	i32 1875935024, ; 285: fr\Microsoft.Maui.Controls.resources => 0x6fd07f30 => 290
	i32 1879696579, ; 286: System.Formats.Tar.dll => 0x7009e4c3 => 41
	i32 1885316902, ; 287: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 211
	i32 1888955245, ; 288: System.Diagnostics.Contracts => 0x70972b6d => 27
	i32 1889954781, ; 289: System.Reflection.Metadata.dll => 0x70a66bdd => 96
	i32 1898237753, ; 290: System.Reflection.DispatchProxy => 0x7124cf39 => 91
	i32 1900610850, ; 291: System.Resources.ResourceManager.dll => 0x71490522 => 101
	i32 1910275211, ; 292: System.Collections.NonGeneric.dll => 0x71dc7c8b => 12
	i32 1939592360, ; 293: System.Private.Xml.Linq => 0x739bd4a8 => 89
	i32 1956758971, ; 294: System.Resources.Writer => 0x74a1c5bb => 102
	i32 1961813231, ; 295: Xamarin.AndroidX.Security.SecurityCrypto.dll => 0x74eee4ef => 257
	i32 1968388702, ; 296: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 176
	i32 1983156543, ; 297: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 277
	i32 1985761444, ; 298: Xamarin.Android.Glide.GifDecoder => 0x765c50a4 => 202
	i32 2003115576, ; 299: el\Microsoft.Maui.Controls.resources => 0x77651e38 => 287
	i32 2011961780, ; 300: System.Buffers.dll => 0x77ec19b4 => 9
	i32 2019465201, ; 301: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 242
	i32 2025202353, ; 302: ar/Microsoft.Maui.Controls.resources.dll => 0x78b622b1 => 282
	i32 2031763787, ; 303: Xamarin.Android.Glide => 0x791a414b => 199
	i32 2045470958, ; 304: System.Private.Xml => 0x79eb68ee => 90
	i32 2055257422, ; 305: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 237
	i32 2060060697, ; 306: System.Windows.dll => 0x7aca0819 => 156
	i32 2066184531, ; 307: de\Microsoft.Maui.Controls.resources => 0x7b277953 => 286
	i32 2070888862, ; 308: System.Diagnostics.TraceSource => 0x7b6f419e => 35
	i32 2079903147, ; 309: System.Runtime.dll => 0x7bf8cdab => 118
	i32 2090596640, ; 310: System.Numerics.Vectors => 0x7c9bf920 => 84
	i32 2127167465, ; 311: System.Console => 0x7ec9ffe9 => 22
	i32 2142473426, ; 312: System.Collections.Specialized => 0x7fb38cd2 => 13
	i32 2143790110, ; 313: System.Xml.XmlSerializer.dll => 0x7fc7a41e => 164
	i32 2146852085, ; 314: Microsoft.VisualBasic.dll => 0x7ff65cf5 => 5
	i32 2159891885, ; 315: Microsoft.Maui => 0x80bd55ad => 188
	i32 2169148018, ; 316: hu\Microsoft.Maui.Controls.resources => 0x814a9272 => 294
	i32 2181898931, ; 317: Microsoft.Extensions.Options.dll => 0x820d22b3 => 183
	i32 2192057212, ; 318: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 181
	i32 2193016926, ; 319: System.ObjectModel.dll => 0x82b6c85e => 86
	i32 2199201384, ; 320: NAudio.dll => 0x83152668 => 191
	i32 2201107256, ; 321: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 281
	i32 2201231467, ; 322: System.Net.Http => 0x8334206b => 66
	i32 2207618523, ; 323: it\Microsoft.Maui.Controls.resources => 0x839595db => 296
	i32 2217644978, ; 324: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 264
	i32 2222056684, ; 325: System.Threading.Tasks.Parallel => 0x8471e4ec => 145
	i32 2244775296, ; 326: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 246
	i32 2252106437, ; 327: System.Xml.Serialization.dll => 0x863c6ac5 => 159
	i32 2256313426, ; 328: System.Globalization.Extensions => 0x867c9c52 => 43
	i32 2265110946, ; 329: System.Security.AccessControl.dll => 0x8702d9a2 => 119
	i32 2266799131, ; 330: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 177
	i32 2267999099, ; 331: Xamarin.Android.Glide.DiskLruCache.dll => 0x872eeb7b => 201
	i32 2270573516, ; 332: fr/Microsoft.Maui.Controls.resources.dll => 0x875633cc => 290
	i32 2279755925, ; 333: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 253
	i32 2293034957, ; 334: System.ServiceModel.Web.dll => 0x88acefcd => 133
	i32 2295906218, ; 335: System.Net.Sockets => 0x88d8bfaa => 77
	i32 2298471582, ; 336: System.Net.Mail => 0x88ffe49e => 68
	i32 2303942373, ; 337: nb\Microsoft.Maui.Controls.resources => 0x89535ee5 => 300
	i32 2305521784, ; 338: System.Private.CoreLib.dll => 0x896b7878 => 174
	i32 2315684594, ; 339: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 205
	i32 2320631194, ; 340: System.Threading.Tasks.Parallel.dll => 0x8a52059a => 145
	i32 2340441535, ; 341: System.Runtime.InteropServices.RuntimeInformation.dll => 0x8b804dbf => 108
	i32 2344264397, ; 342: System.ValueTuple => 0x8bbaa2cd => 153
	i32 2353062107, ; 343: System.Net.Primitives => 0x8c40e0db => 72
	i32 2368005991, ; 344: System.Xml.ReaderWriter.dll => 0x8d24e767 => 158
	i32 2371007202, ; 345: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 176
	i32 2378619854, ; 346: System.Security.Cryptography.Csp.dll => 0x8dc6dbce => 123
	i32 2383496789, ; 347: System.Security.Principal.Windows.dll => 0x8e114655 => 129
	i32 2385305715, ; 348: NAudio.Wasapi.dll => 0x8e2ce073 => 195
	i32 2395872292, ; 349: id\Microsoft.Maui.Controls.resources => 0x8ece1c24 => 295
	i32 2401565422, ; 350: System.Web.HttpUtility => 0x8f24faee => 154
	i32 2403452196, ; 351: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 228
	i32 2421380589, ; 352: System.Threading.Tasks.Dataflow => 0x905355ed => 143
	i32 2423080555, ; 353: Xamarin.AndroidX.Collection.Ktx.dll => 0x906d466b => 215
	i32 2427813419, ; 354: hi\Microsoft.Maui.Controls.resources => 0x90b57e2b => 292
	i32 2435356389, ; 355: System.Console.dll => 0x912896e5 => 22
	i32 2435904999, ; 356: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 16
	i32 2454642406, ; 357: System.Text.Encoding.dll => 0x924edee6 => 137
	i32 2458678730, ; 358: System.Net.Sockets.dll => 0x928c75ca => 77
	i32 2459001652, ; 359: System.Linq.Parallel.dll => 0x92916334 => 61
	i32 2465532216, ; 360: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 218
	i32 2471841756, ; 361: netstandard.dll => 0x93554fdc => 169
	i32 2475788418, ; 362: Java.Interop.dll => 0x93918882 => 170
	i32 2478825641, ; 363: cs/Trener.resources.dll => 0x93bfe0a9 => 0
	i32 2480646305, ; 364: Microsoft.Maui.Controls => 0x93dba8a1 => 186
	i32 2483903535, ; 365: System.ComponentModel.EventBasedAsync => 0x940d5c2f => 17
	i32 2484371297, ; 366: System.Net.ServicePoint => 0x94147f61 => 76
	i32 2490993605, ; 367: System.AppContext.dll => 0x94798bc5 => 8
	i32 2501346920, ; 368: System.Data.DataSetExtensions => 0x95178668 => 25
	i32 2505896520, ; 369: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 240
	i32 2522472828, ; 370: Xamarin.Android.Glide.dll => 0x9659e17c => 199
	i32 2538310050, ; 371: System.Reflection.Emit.Lightweight.dll => 0x974b89a2 => 93
	i32 2550873716, ; 372: hr\Microsoft.Maui.Controls.resources => 0x980b3e74 => 293
	i32 2562349572, ; 373: Microsoft.CSharp => 0x98ba5a04 => 3
	i32 2570120770, ; 374: System.Text.Encodings.Web => 0x9930ee42 => 138
	i32 2581783588, ; 375: Xamarin.AndroidX.Lifecycle.Runtime.Ktx => 0x99e2e424 => 241
	i32 2581819634, ; 376: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 263
	i32 2585220780, ; 377: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 136
	i32 2585805581, ; 378: System.Net.Ping => 0x9a20430d => 71
	i32 2589602615, ; 379: System.Threading.ThreadPool => 0x9a5a3337 => 148
	i32 2593496499, ; 380: pl\Microsoft.Maui.Controls.resources => 0x9a959db3 => 302
	i32 2605712449, ; 381: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 281
	i32 2615233544, ; 382: Xamarin.AndroidX.Fragment.Ktx => 0x9be14c08 => 232
	i32 2616218305, ; 383: Microsoft.Extensions.Logging.Debug.dll => 0x9bf052c1 => 182
	i32 2617129537, ; 384: System.Private.Xml.dll => 0x9bfe3a41 => 90
	i32 2618712057, ; 385: System.Reflection.TypeExtensions.dll => 0x9c165ff9 => 98
	i32 2620871830, ; 386: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 222
	i32 2624644809, ; 387: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 227
	i32 2626831493, ; 388: ja\Microsoft.Maui.Controls.resources => 0x9c924485 => 297
	i32 2627185994, ; 389: System.Diagnostics.TextWriterTraceListener.dll => 0x9c97ad4a => 33
	i32 2629843544, ; 390: System.IO.Compression.ZipFile.dll => 0x9cc03a58 => 47
	i32 2633051222, ; 391: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 236
	i32 2663391936, ; 392: Xamarin.Android.Glide.DiskLruCache => 0x9ec022c0 => 201
	i32 2663698177, ; 393: System.Runtime.Loader => 0x9ec4cf01 => 111
	i32 2664396074, ; 394: System.Xml.XDocument.dll => 0x9ecf752a => 160
	i32 2665622720, ; 395: System.Drawing.Primitives => 0x9ee22cc0 => 37
	i32 2676780864, ; 396: System.Data.Common.dll => 0x9f8c6f40 => 24
	i32 2686887180, ; 397: System.Runtime.Serialization.Xml.dll => 0xa026a50c => 116
	i32 2693849962, ; 398: System.IO.dll => 0xa090e36a => 59
	i32 2701096212, ; 399: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 261
	i32 2715334215, ; 400: System.Threading.Tasks.dll => 0xa1d8b647 => 146
	i32 2717744543, ; 401: System.Security.Claims => 0xa1fd7d9f => 120
	i32 2719963679, ; 402: System.Security.Cryptography.Cng.dll => 0xa21f5a1f => 122
	i32 2724373263, ; 403: System.Runtime.Numerics.dll => 0xa262a30f => 112
	i32 2732626843, ; 404: Xamarin.AndroidX.Activity => 0xa2e0939b => 203
	i32 2735172069, ; 405: System.Threading.Channels => 0xa30769e5 => 141
	i32 2737747696, ; 406: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 209
	i32 2740948882, ; 407: System.IO.Pipes.AccessControl => 0xa35f8f92 => 56
	i32 2748088231, ; 408: System.Runtime.InteropServices.JavaScript => 0xa3cc7fa7 => 107
	i32 2752995522, ; 409: pt-BR\Microsoft.Maui.Controls.resources => 0xa41760c2 => 303
	i32 2758225723, ; 410: Microsoft.Maui.Controls.Xaml => 0xa4672f3b => 187
	i32 2764765095, ; 411: Microsoft.Maui.dll => 0xa4caf7a7 => 188
	i32 2765824710, ; 412: System.Text.Encoding.CodePages.dll => 0xa4db22c6 => 135
	i32 2770495804, ; 413: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 275
	i32 2778768386, ; 414: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 266
	i32 2779977773, ; 415: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 254
	i32 2785988530, ; 416: th\Microsoft.Maui.Controls.resources => 0xa60ecfb2 => 309
	i32 2788224221, ; 417: Xamarin.AndroidX.Fragment.Ktx.dll => 0xa630ecdd => 232
	i32 2801831435, ; 418: Microsoft.Maui.Graphics => 0xa7008e0b => 190
	i32 2803228030, ; 419: System.Xml.XPath.XDocument.dll => 0xa715dd7e => 161
	i32 2806116107, ; 420: es/Microsoft.Maui.Controls.resources.dll => 0xa741ef0b => 288
	i32 2810250172, ; 421: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 219
	i32 2819470561, ; 422: System.Xml.dll => 0xa80db4e1 => 165
	i32 2821205001, ; 423: System.ServiceProcess.dll => 0xa8282c09 => 134
	i32 2821294376, ; 424: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 254
	i32 2824502124, ; 425: System.Xml.XmlDocument => 0xa85a7b6c => 163
	i32 2831556043, ; 426: nl/Microsoft.Maui.Controls.resources.dll => 0xa8c61dcb => 301
	i32 2838993487, ; 427: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx.dll => 0xa9379a4f => 243
	i32 2849599387, ; 428: System.Threading.Overlapped.dll => 0xa9d96f9b => 142
	i32 2853208004, ; 429: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 266
	i32 2855708567, ; 430: Xamarin.AndroidX.Transition => 0xaa36a797 => 262
	i32 2861098320, ; 431: Mono.Android.Export.dll => 0xaa88e550 => 171
	i32 2861189240, ; 432: Microsoft.Maui.Essentials => 0xaa8a4878 => 189
	i32 2870099610, ; 433: Xamarin.AndroidX.Activity.Ktx.dll => 0xab123e9a => 204
	i32 2875164099, ; 434: Jsr305Binding.dll => 0xab5f85c3 => 271
	i32 2875220617, ; 435: System.Globalization.Calendars.dll => 0xab606289 => 42
	i32 2884993177, ; 436: Xamarin.AndroidX.ExifInterface => 0xabf58099 => 230
	i32 2887636118, ; 437: System.Net.dll => 0xac1dd496 => 83
	i32 2899753641, ; 438: System.IO.UnmanagedMemoryStream => 0xacd6baa9 => 58
	i32 2900621748, ; 439: System.Dynamic.Runtime.dll => 0xace3f9b4 => 39
	i32 2901442782, ; 440: System.Reflection => 0xacf080de => 99
	i32 2905242038, ; 441: mscorlib.dll => 0xad2a79b6 => 168
	i32 2909740682, ; 442: System.Private.CoreLib => 0xad6f1e8a => 174
	i32 2916838712, ; 443: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 267
	i32 2917248660, ; 444: en/Trener.resources.dll => 0xade1ae94 => 1
	i32 2919462931, ; 445: System.Numerics.Vectors.dll => 0xae037813 => 84
	i32 2921128767, ; 446: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 206
	i32 2936416060, ; 447: System.Resources.Reader => 0xaf06273c => 100
	i32 2940926066, ; 448: System.Diagnostics.StackTrace.dll => 0xaf4af872 => 32
	i32 2942453041, ; 449: System.Xml.XPath.XDocument => 0xaf624531 => 161
	i32 2959614098, ; 450: System.ComponentModel.dll => 0xb0682092 => 20
	i32 2968338931, ; 451: System.Security.Principal.Windows => 0xb0ed41f3 => 129
	i32 2972252294, ; 452: System.Security.Cryptography.Algorithms.dll => 0xb128f886 => 121
	i32 2978675010, ; 453: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 226
	i32 2987532451, ; 454: Xamarin.AndroidX.Security.SecurityCrypto => 0xb21220a3 => 257
	i32 2991755712, ; 455: NAudio.Asio.dll => 0xb25291c0 => 192
	i32 2996846495, ; 456: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 239
	i32 3016983068, ; 457: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 259
	i32 3023353419, ; 458: WindowsBase.dll => 0xb434b64b => 167
	i32 3024354802, ; 459: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 234
	i32 3038032645, ; 460: _Microsoft.Android.Resource.Designer.dll => 0xb514b305 => 316
	i32 3056245963, ; 461: Xamarin.AndroidX.SavedState.SavedState.Ktx => 0xb62a9ccb => 256
	i32 3057625584, ; 462: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 247
	i32 3059408633, ; 463: Mono.Android.Runtime => 0xb65adef9 => 172
	i32 3059793426, ; 464: System.ComponentModel.Primitives => 0xb660be12 => 18
	i32 3061151445, ; 465: NAudio.WinMM => 0xb67576d5 => 196
	i32 3075834255, ; 466: System.Threading.Tasks => 0xb755818f => 146
	i32 3077302341, ; 467: hu/Microsoft.Maui.Controls.resources.dll => 0xb76be845 => 294
	i32 3081487099, ; 468: Trener.dll => 0xb7abc2fb => 2
	i32 3090735792, ; 469: System.Security.Cryptography.X509Certificates.dll => 0xb838e2b0 => 127
	i32 3099732863, ; 470: System.Security.Claims.dll => 0xb8c22b7f => 120
	i32 3103600923, ; 471: System.Formats.Asn1 => 0xb8fd311b => 40
	i32 3111772706, ; 472: System.Runtime.Serialization => 0xb979e222 => 117
	i32 3121463068, ; 473: System.IO.FileSystem.AccessControl.dll => 0xba0dbf1c => 49
	i32 3124832203, ; 474: System.Threading.Tasks.Extensions => 0xba4127cb => 144
	i32 3132293585, ; 475: System.Security.AccessControl => 0xbab301d1 => 119
	i32 3147165239, ; 476: System.Diagnostics.Tracing.dll => 0xbb95ee37 => 36
	i32 3148237826, ; 477: GoogleGson.dll => 0xbba64c02 => 175
	i32 3159123045, ; 478: System.Reflection.Primitives.dll => 0xbc4c6465 => 97
	i32 3160747431, ; 479: System.IO.MemoryMappedFiles => 0xbc652da7 => 55
	i32 3178803400, ; 480: Xamarin.AndroidX.Navigation.Fragment.dll => 0xbd78b0c8 => 248
	i32 3192346100, ; 481: System.Security.SecureString => 0xbe4755f4 => 131
	i32 3193515020, ; 482: System.Web => 0xbe592c0c => 155
	i32 3204380047, ; 483: System.Data.dll => 0xbefef58f => 26
	i32 3209718065, ; 484: System.Xml.XmlDocument.dll => 0xbf506931 => 163
	i32 3211777861, ; 485: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 225
	i32 3220365878, ; 486: System.Threading => 0xbff2e236 => 150
	i32 3226221578, ; 487: System.Runtime.Handles.dll => 0xc04c3c0a => 106
	i32 3251039220, ; 488: System.Reflection.DispatchProxy.dll => 0xc1c6ebf4 => 91
	i32 3258312781, ; 489: Xamarin.AndroidX.CardView => 0xc235e84d => 213
	i32 3265493905, ; 490: System.Linq.Queryable.dll => 0xc2a37b91 => 62
	i32 3265893370, ; 491: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 144
	i32 3277815716, ; 492: System.Resources.Writer.dll => 0xc35f7fa4 => 102
	i32 3279906254, ; 493: Microsoft.Win32.Registry.dll => 0xc37f65ce => 7
	i32 3280506390, ; 494: System.ComponentModel.Annotations.dll => 0xc3888e16 => 15
	i32 3290767353, ; 495: System.Security.Cryptography.Encoding => 0xc4251ff9 => 124
	i32 3299363146, ; 496: System.Text.Encoding => 0xc4a8494a => 137
	i32 3303498502, ; 497: System.Diagnostics.FileVersionInfo => 0xc4e76306 => 30
	i32 3305363605, ; 498: fi\Microsoft.Maui.Controls.resources => 0xc503d895 => 289
	i32 3316684772, ; 499: System.Net.Requests.dll => 0xc5b097e4 => 74
	i32 3317135071, ; 500: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 223
	i32 3317144872, ; 501: System.Data => 0xc5b79d28 => 26
	i32 3340387945, ; 502: SkiaSharp => 0xc71a4669 => 198
	i32 3340431453, ; 503: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 211
	i32 3345895724, ; 504: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 252
	i32 3346324047, ; 505: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 249
	i32 3357674450, ; 506: ru\Microsoft.Maui.Controls.resources => 0xc8220bd2 => 306
	i32 3358260929, ; 507: System.Text.Json => 0xc82afec1 => 139
	i32 3362336904, ; 508: Xamarin.AndroidX.Activity.Ktx => 0xc8693088 => 204
	i32 3362522851, ; 509: Xamarin.AndroidX.Core => 0xc86c06e3 => 220
	i32 3366347497, ; 510: Java.Interop => 0xc8a662e9 => 170
	i32 3374999561, ; 511: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 253
	i32 3381016424, ; 512: da\Microsoft.Maui.Controls.resources => 0xc9863768 => 285
	i32 3395150330, ; 513: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 103
	i32 3403906625, ; 514: System.Security.Cryptography.OpenSsl.dll => 0xcae37e41 => 125
	i32 3405233483, ; 515: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 224
	i32 3428513518, ; 516: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 178
	i32 3429136800, ; 517: System.Xml => 0xcc6479a0 => 165
	i32 3430777524, ; 518: netstandard => 0xcc7d82b4 => 169
	i32 3441283291, ; 519: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 227
	i32 3445260447, ; 520: System.Formats.Tar => 0xcd5a809f => 41
	i32 3452344032, ; 521: Microsoft.Maui.Controls.Compatibility.dll => 0xcdc696e0 => 185
	i32 3463511458, ; 522: hr/Microsoft.Maui.Controls.resources.dll => 0xce70fda2 => 293
	i32 3471940407, ; 523: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 19
	i32 3476120550, ; 524: Mono.Android => 0xcf3163e6 => 173
	i32 3479583265, ; 525: ru/Microsoft.Maui.Controls.resources.dll => 0xcf663a21 => 306
	i32 3484440000, ; 526: ro\Microsoft.Maui.Controls.resources => 0xcfb055c0 => 305
	i32 3485117614, ; 527: System.Text.Json.dll => 0xcfbaacae => 139
	i32 3486566296, ; 528: System.Transactions => 0xcfd0c798 => 152
	i32 3493954962, ; 529: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 216
	i32 3508241679, ; 530: NAudio.Asio => 0xd11b850f => 192
	i32 3509114376, ; 531: System.Xml.Linq => 0xd128d608 => 157
	i32 3515174580, ; 532: System.Security.dll => 0xd1854eb4 => 132
	i32 3530912306, ; 533: System.Configuration => 0xd2757232 => 21
	i32 3539954161, ; 534: System.Net.HttpListener => 0xd2ff69f1 => 67
	i32 3560100363, ; 535: System.Threading.Timer => 0xd432d20b => 149
	i32 3570554715, ; 536: System.IO.FileSystem.AccessControl => 0xd4d2575b => 49
	i32 3580758918, ; 537: zh-HK\Microsoft.Maui.Controls.resources => 0xd56e0b86 => 313
	i32 3597029428, ; 538: Xamarin.Android.Glide.GifDecoder.dll => 0xd6665034 => 202
	i32 3598340787, ; 539: System.Net.WebSockets.Client => 0xd67a52b3 => 81
	i32 3608333028, ; 540: Trener => 0xd712cae4 => 2
	i32 3608519521, ; 541: System.Linq.dll => 0xd715a361 => 63
	i32 3624195450, ; 542: System.Runtime.InteropServices.RuntimeInformation => 0xd804d57a => 108
	i32 3627220390, ; 543: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 251
	i32 3633644679, ; 544: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 206
	i32 3638274909, ; 545: System.IO.FileSystem.Primitives.dll => 0xd8dbab5d => 51
	i32 3641597786, ; 546: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 237
	i32 3643446276, ; 547: tr\Microsoft.Maui.Controls.resources => 0xd92a9404 => 310
	i32 3643854240, ; 548: Xamarin.AndroidX.Navigation.Fragment => 0xd930cda0 => 248
	i32 3645089577, ; 549: System.ComponentModel.DataAnnotations => 0xd943a729 => 16
	i32 3657292374, ; 550: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 177
	i32 3660523487, ; 551: System.Net.NetworkInformation => 0xda2f27df => 70
	i32 3660726404, ; 552: Plugin.Maui.Audio.dll => 0xda324084 => 197
	i32 3672681054, ; 553: Mono.Android.dll => 0xdae8aa5e => 173
	i32 3682565725, ; 554: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 212
	i32 3684561358, ; 555: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 216
	i32 3697841164, ; 556: zh-Hant/Microsoft.Maui.Controls.resources.dll => 0xdc68940c => 315
	i32 3700866549, ; 557: System.Net.WebProxy.dll => 0xdc96bdf5 => 80
	i32 3706696989, ; 558: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 221
	i32 3716563718, ; 559: System.Runtime.Intrinsics => 0xdd864306 => 110
	i32 3718780102, ; 560: Xamarin.AndroidX.Annotation => 0xdda814c6 => 205
	i32 3724971120, ; 561: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 247
	i32 3732100267, ; 562: System.Net.NameResolution => 0xde7354ab => 69
	i32 3737834244, ; 563: System.Net.Http.Json.dll => 0xdecad304 => 65
	i32 3748608112, ; 564: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 29
	i32 3751444290, ; 565: System.Xml.XPath => 0xdf9a7f42 => 162
	i32 3786282454, ; 566: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 214
	i32 3792276235, ; 567: System.Collections.NonGeneric => 0xe2098b0b => 12
	i32 3800979733, ; 568: Microsoft.Maui.Controls.Compatibility => 0xe28e5915 => 185
	i32 3802395368, ; 569: System.Collections.Specialized.dll => 0xe2a3f2e8 => 13
	i32 3819260425, ; 570: System.Net.WebProxy => 0xe3a54a09 => 80
	i32 3823082795, ; 571: System.Security.Cryptography.dll => 0xe3df9d2b => 128
	i32 3829621856, ; 572: System.Numerics.dll => 0xe4436460 => 85
	i32 3831870545, ; 573: NAudio.WinMM.dll => 0xe465b451 => 196
	i32 3833826689, ; 574: NAudio.Core.dll => 0xe4838d81 => 193
	i32 3841636137, ; 575: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 179
	i32 3844307129, ; 576: System.Net.Mail.dll => 0xe52378b9 => 68
	i32 3849253459, ; 577: System.Runtime.InteropServices.dll => 0xe56ef253 => 109
	i32 3870376305, ; 578: System.Net.HttpListener.dll => 0xe6b14171 => 67
	i32 3873536506, ; 579: System.Security.Principal => 0xe6e179fa => 130
	i32 3875112723, ; 580: System.Security.Cryptography.Encoding.dll => 0xe6f98713 => 124
	i32 3885497537, ; 581: System.Net.WebHeaderCollection.dll => 0xe797fcc1 => 79
	i32 3885922214, ; 582: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 262
	i32 3887389151, ; 583: NAudio.Midi => 0xe7b4d9df => 194
	i32 3888767677, ; 584: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 252
	i32 3889960447, ; 585: zh-Hans/Microsoft.Maui.Controls.resources.dll => 0xe7dc15ff => 314
	i32 3896106733, ; 586: System.Collections.Concurrent.dll => 0xe839deed => 10
	i32 3896760992, ; 587: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 220
	i32 3901907137, ; 588: Microsoft.VisualBasic.Core.dll => 0xe89260c1 => 4
	i32 3920810846, ; 589: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 46
	i32 3921031405, ; 590: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 265
	i32 3928044579, ; 591: System.Xml.ReaderWriter => 0xea213423 => 158
	i32 3930554604, ; 592: System.Security.Principal.dll => 0xea4780ec => 130
	i32 3931092270, ; 593: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 250
	i32 3945713374, ; 594: System.Data.DataSetExtensions.dll => 0xeb2ecede => 25
	i32 3953953790, ; 595: System.Text.Encoding.CodePages => 0xebac8bfe => 135
	i32 3955647286, ; 596: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 208
	i32 3959773229, ; 597: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 239
	i32 3980434154, ; 598: th/Microsoft.Maui.Controls.resources.dll => 0xed409aea => 309
	i32 3987592930, ; 599: he/Microsoft.Maui.Controls.resources.dll => 0xedadd6e2 => 291
	i32 4003436829, ; 600: System.Diagnostics.Process.dll => 0xee9f991d => 31
	i32 4015948917, ; 601: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 207
	i32 4025784931, ; 602: System.Memory => 0xeff49a63 => 64
	i32 4046471985, ; 603: Microsoft.Maui.Controls.Xaml.dll => 0xf1304331 => 187
	i32 4054681211, ; 604: System.Reflection.Emit.ILGeneration => 0xf1ad867b => 92
	i32 4068434129, ; 605: System.Private.Xml.Linq.dll => 0xf27f60d1 => 89
	i32 4073602200, ; 606: System.Threading.dll => 0xf2ce3c98 => 150
	i32 4094352644, ; 607: Microsoft.Maui.Essentials.dll => 0xf40add04 => 189
	i32 4099507663, ; 608: System.Drawing.dll => 0xf45985cf => 38
	i32 4100113165, ; 609: System.Private.Uri => 0xf462c30d => 88
	i32 4101593132, ; 610: Xamarin.AndroidX.Emoji2 => 0xf479582c => 228
	i32 4102112229, ; 611: pt/Microsoft.Maui.Controls.resources.dll => 0xf48143e5 => 304
	i32 4125707920, ; 612: ms/Microsoft.Maui.Controls.resources.dll => 0xf5e94e90 => 299
	i32 4126470640, ; 613: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 178
	i32 4127667938, ; 614: System.IO.FileSystem.Watcher => 0xf60736e2 => 52
	i32 4130442656, ; 615: System.AppContext => 0xf6318da0 => 8
	i32 4147896353, ; 616: System.Reflection.Emit.ILGeneration.dll => 0xf73be021 => 92
	i32 4150914736, ; 617: uk\Microsoft.Maui.Controls.resources => 0xf769eeb0 => 311
	i32 4151237749, ; 618: System.Core => 0xf76edc75 => 23
	i32 4159265925, ; 619: System.Xml.XmlSerializer => 0xf7e95c85 => 164
	i32 4161255271, ; 620: System.Reflection.TypeExtensions => 0xf807b767 => 98
	i32 4164802419, ; 621: System.IO.FileSystem.Watcher.dll => 0xf83dd773 => 52
	i32 4181436372, ; 622: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 115
	i32 4182413190, ; 623: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 244
	i32 4185676441, ; 624: System.Security => 0xf97c5a99 => 132
	i32 4196529839, ; 625: System.Net.WebClient.dll => 0xfa21f6af => 78
	i32 4213026141, ; 626: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 29
	i32 4256097574, ; 627: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 221
	i32 4258378803, ; 628: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx => 0xfdd1b433 => 243
	i32 4260525087, ; 629: System.Buffers => 0xfdf2741f => 9
	i32 4271975918, ; 630: Microsoft.Maui.Controls.dll => 0xfea12dee => 186
	i32 4274976490, ; 631: System.Runtime.Numerics => 0xfecef6ea => 112
	i32 4292120959, ; 632: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 244
	i32 4294763496 ; 633: Xamarin.AndroidX.ExifInterface.dll => 0xfffce3e8 => 230
], align 4

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [634 x i32] [
	i32 70, ; 0
	i32 69, ; 1
	i32 110, ; 2
	i32 240, ; 3
	i32 274, ; 4
	i32 50, ; 5
	i32 82, ; 6
	i32 147, ; 7
	i32 32, ; 8
	i32 315, ; 9
	i32 126, ; 10
	i32 190, ; 11
	i32 104, ; 12
	i32 258, ; 13
	i32 109, ; 14
	i32 258, ; 15
	i32 141, ; 16
	i32 278, ; 17
	i32 79, ; 18
	i32 126, ; 19
	i32 195, ; 20
	i32 15, ; 21
	i32 214, ; 22
	i32 134, ; 23
	i32 260, ; 24
	i32 153, ; 25
	i32 312, ; 26
	i32 313, ; 27
	i32 20, ; 28
	i32 212, ; 29
	i32 28, ; 30
	i32 234, ; 31
	i32 3, ; 32
	i32 61, ; 33
	i32 44, ; 34
	i32 93, ; 35
	i32 217, ; 36
	i32 149, ; 37
	i32 236, ; 38
	i32 233, ; 39
	i32 284, ; 40
	i32 56, ; 41
	i32 71, ; 42
	i32 312, ; 43
	i32 203, ; 44
	i32 85, ; 45
	i32 297, ; 46
	i32 235, ; 47
	i32 296, ; 48
	i32 133, ; 49
	i32 57, ; 50
	i32 151, ; 51
	i32 76, ; 52
	i32 147, ; 53
	i32 64, ; 54
	i32 148, ; 55
	i32 316, ; 56
	i32 167, ; 57
	i32 308, ; 58
	i32 218, ; 59
	i32 14, ; 60
	i32 231, ; 61
	i32 127, ; 62
	i32 154, ; 63
	i32 115, ; 64
	i32 168, ; 65
	i32 166, ; 66
	i32 233, ; 67
	i32 246, ; 68
	i32 86, ; 69
	i32 295, ; 70
	i32 289, ; 71
	i32 184, ; 72
	i32 198, ; 73
	i32 152, ; 74
	i32 278, ; 75
	i32 62, ; 76
	i32 180, ; 77
	i32 53, ; 78
	i32 105, ; 79
	i32 116, ; 80
	i32 42, ; 81
	i32 271, ; 82
	i32 269, ; 83
	i32 122, ; 84
	i32 303, ; 85
	i32 54, ; 86
	i32 46, ; 87
	i32 121, ; 88
	i32 223, ; 89
	i32 301, ; 90
	i32 229, ; 91
	i32 83, ; 92
	i32 138, ; 93
	i32 265, ; 94
	i32 210, ; 95
	i32 10, ; 96
	i32 75, ; 97
	i32 283, ; 98
	i32 157, ; 99
	i32 280, ; 100
	i32 156, ; 101
	i32 94, ; 102
	i32 275, ; 103
	i32 47, ; 104
	i32 298, ; 105
	i32 286, ; 106
	i32 279, ; 107
	i32 111, ; 108
	i32 131, ; 109
	i32 27, ; 110
	i32 200, ; 111
	i32 74, ; 112
	i32 57, ; 113
	i32 48, ; 114
	i32 307, ; 115
	i32 183, ; 116
	i32 224, ; 117
	i32 24, ; 118
	i32 238, ; 119
	i32 88, ; 120
	i32 45, ; 121
	i32 162, ; 122
	i32 73, ; 123
	i32 251, ; 124
	i32 5, ; 125
	i32 44, ; 126
	i32 65, ; 127
	i32 18, ; 128
	i32 55, ; 129
	i32 310, ; 130
	i32 274, ; 131
	i32 107, ; 132
	i32 279, ; 133
	i32 272, ; 134
	i32 235, ; 135
	i32 36, ; 136
	i32 160, ; 137
	i32 87, ; 138
	i32 34, ; 139
	i32 14, ; 140
	i32 53, ; 141
	i32 58, ; 142
	i32 255, ; 143
	i32 38, ; 144
	i32 179, ; 145
	i32 285, ; 146
	i32 273, ; 147
	i32 208, ; 148
	i32 37, ; 149
	i32 60, ; 150
	i32 242, ; 151
	i32 175, ; 152
	i32 19, ; 153
	i32 276, ; 154
	i32 166, ; 155
	i32 298, ; 156
	i32 241, ; 157
	i32 182, ; 158
	i32 268, ; 159
	i32 304, ; 160
	i32 155, ; 161
	i32 264, ; 162
	i32 249, ; 163
	i32 302, ; 164
	i32 210, ; 165
	i32 31, ; 166
	i32 54, ; 167
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
	i32 87, ; 179
	i32 268, ; 180
	i32 63, ; 181
	i32 114, ; 182
	i32 197, ; 183
	i32 59, ; 184
	i32 314, ; 185
	i32 255, ; 186
	i32 101, ; 187
	i32 21, ; 188
	i32 219, ; 189
	i32 113, ; 190
	i32 103, ; 191
	i32 104, ; 192
	i32 282, ; 193
	i32 106, ; 194
	i32 272, ; 195
	i32 73, ; 196
	i32 40, ; 197
	i32 34, ; 198
	i32 105, ; 199
	i32 75, ; 200
	i32 288, ; 201
	i32 11, ; 202
	i32 125, ; 203
	i32 48, ; 204
	i32 209, ; 205
	i32 184, ; 206
	i32 11, ; 207
	i32 45, ; 208
	i32 6, ; 209
	i32 193, ; 210
	i32 256, ; 211
	i32 292, ; 212
	i32 194, ; 213
	i32 287, ; 214
	i32 33, ; 215
	i32 140, ; 216
	i32 94, ; 217
	i32 1, ; 218
	i32 95, ; 219
	i32 307, ; 220
	i32 51, ; 221
	i32 143, ; 222
	i32 114, ; 223
	i32 142, ; 224
	i32 225, ; 225
	i32 117, ; 226
	i32 273, ; 227
	i32 159, ; 228
	i32 78, ; 229
	i32 81, ; 230
	i32 245, ; 231
	i32 39, ; 232
	i32 267, ; 233
	i32 229, ; 234
	i32 222, ; 235
	i32 66, ; 236
	i32 140, ; 237
	i32 17, ; 238
	i32 191, ; 239
	i32 118, ; 240
	i32 261, ; 241
	i32 270, ; 242
	i32 217, ; 243
	i32 50, ; 244
	i32 72, ; 245
	i32 82, ; 246
	i32 128, ; 247
	i32 96, ; 248
	i32 123, ; 249
	i32 277, ; 250
	i32 28, ; 251
	i32 238, ; 252
	i32 99, ; 253
	i32 30, ; 254
	i32 213, ; 255
	i32 305, ; 256
	i32 283, ; 257
	i32 151, ; 258
	i32 171, ; 259
	i32 6, ; 260
	i32 100, ; 261
	i32 35, ; 262
	i32 95, ; 263
	i32 260, ; 264
	i32 180, ; 265
	i32 23, ; 266
	i32 43, ; 267
	i32 172, ; 268
	i32 299, ; 269
	i32 231, ; 270
	i32 291, ; 271
	i32 245, ; 272
	i32 276, ; 273
	i32 270, ; 274
	i32 250, ; 275
	i32 4, ; 276
	i32 136, ; 277
	i32 113, ; 278
	i32 181, ; 279
	i32 311, ; 280
	i32 200, ; 281
	i32 308, ; 282
	i32 60, ; 283
	i32 97, ; 284
	i32 290, ; 285
	i32 41, ; 286
	i32 211, ; 287
	i32 27, ; 288
	i32 96, ; 289
	i32 91, ; 290
	i32 101, ; 291
	i32 12, ; 292
	i32 89, ; 293
	i32 102, ; 294
	i32 257, ; 295
	i32 176, ; 296
	i32 277, ; 297
	i32 202, ; 298
	i32 287, ; 299
	i32 9, ; 300
	i32 242, ; 301
	i32 282, ; 302
	i32 199, ; 303
	i32 90, ; 304
	i32 237, ; 305
	i32 156, ; 306
	i32 286, ; 307
	i32 35, ; 308
	i32 118, ; 309
	i32 84, ; 310
	i32 22, ; 311
	i32 13, ; 312
	i32 164, ; 313
	i32 5, ; 314
	i32 188, ; 315
	i32 294, ; 316
	i32 183, ; 317
	i32 181, ; 318
	i32 86, ; 319
	i32 191, ; 320
	i32 281, ; 321
	i32 66, ; 322
	i32 296, ; 323
	i32 264, ; 324
	i32 145, ; 325
	i32 246, ; 326
	i32 159, ; 327
	i32 43, ; 328
	i32 119, ; 329
	i32 177, ; 330
	i32 201, ; 331
	i32 290, ; 332
	i32 253, ; 333
	i32 133, ; 334
	i32 77, ; 335
	i32 68, ; 336
	i32 300, ; 337
	i32 174, ; 338
	i32 205, ; 339
	i32 145, ; 340
	i32 108, ; 341
	i32 153, ; 342
	i32 72, ; 343
	i32 158, ; 344
	i32 176, ; 345
	i32 123, ; 346
	i32 129, ; 347
	i32 195, ; 348
	i32 295, ; 349
	i32 154, ; 350
	i32 228, ; 351
	i32 143, ; 352
	i32 215, ; 353
	i32 292, ; 354
	i32 22, ; 355
	i32 16, ; 356
	i32 137, ; 357
	i32 77, ; 358
	i32 61, ; 359
	i32 218, ; 360
	i32 169, ; 361
	i32 170, ; 362
	i32 0, ; 363
	i32 186, ; 364
	i32 17, ; 365
	i32 76, ; 366
	i32 8, ; 367
	i32 25, ; 368
	i32 240, ; 369
	i32 199, ; 370
	i32 93, ; 371
	i32 293, ; 372
	i32 3, ; 373
	i32 138, ; 374
	i32 241, ; 375
	i32 263, ; 376
	i32 136, ; 377
	i32 71, ; 378
	i32 148, ; 379
	i32 302, ; 380
	i32 281, ; 381
	i32 232, ; 382
	i32 182, ; 383
	i32 90, ; 384
	i32 98, ; 385
	i32 222, ; 386
	i32 227, ; 387
	i32 297, ; 388
	i32 33, ; 389
	i32 47, ; 390
	i32 236, ; 391
	i32 201, ; 392
	i32 111, ; 393
	i32 160, ; 394
	i32 37, ; 395
	i32 24, ; 396
	i32 116, ; 397
	i32 59, ; 398
	i32 261, ; 399
	i32 146, ; 400
	i32 120, ; 401
	i32 122, ; 402
	i32 112, ; 403
	i32 203, ; 404
	i32 141, ; 405
	i32 209, ; 406
	i32 56, ; 407
	i32 107, ; 408
	i32 303, ; 409
	i32 187, ; 410
	i32 188, ; 411
	i32 135, ; 412
	i32 275, ; 413
	i32 266, ; 414
	i32 254, ; 415
	i32 309, ; 416
	i32 232, ; 417
	i32 190, ; 418
	i32 161, ; 419
	i32 288, ; 420
	i32 219, ; 421
	i32 165, ; 422
	i32 134, ; 423
	i32 254, ; 424
	i32 163, ; 425
	i32 301, ; 426
	i32 243, ; 427
	i32 142, ; 428
	i32 266, ; 429
	i32 262, ; 430
	i32 171, ; 431
	i32 189, ; 432
	i32 204, ; 433
	i32 271, ; 434
	i32 42, ; 435
	i32 230, ; 436
	i32 83, ; 437
	i32 58, ; 438
	i32 39, ; 439
	i32 99, ; 440
	i32 168, ; 441
	i32 174, ; 442
	i32 267, ; 443
	i32 1, ; 444
	i32 84, ; 445
	i32 206, ; 446
	i32 100, ; 447
	i32 32, ; 448
	i32 161, ; 449
	i32 20, ; 450
	i32 129, ; 451
	i32 121, ; 452
	i32 226, ; 453
	i32 257, ; 454
	i32 192, ; 455
	i32 239, ; 456
	i32 259, ; 457
	i32 167, ; 458
	i32 234, ; 459
	i32 316, ; 460
	i32 256, ; 461
	i32 247, ; 462
	i32 172, ; 463
	i32 18, ; 464
	i32 196, ; 465
	i32 146, ; 466
	i32 294, ; 467
	i32 2, ; 468
	i32 127, ; 469
	i32 120, ; 470
	i32 40, ; 471
	i32 117, ; 472
	i32 49, ; 473
	i32 144, ; 474
	i32 119, ; 475
	i32 36, ; 476
	i32 175, ; 477
	i32 97, ; 478
	i32 55, ; 479
	i32 248, ; 480
	i32 131, ; 481
	i32 155, ; 482
	i32 26, ; 483
	i32 163, ; 484
	i32 225, ; 485
	i32 150, ; 486
	i32 106, ; 487
	i32 91, ; 488
	i32 213, ; 489
	i32 62, ; 490
	i32 144, ; 491
	i32 102, ; 492
	i32 7, ; 493
	i32 15, ; 494
	i32 124, ; 495
	i32 137, ; 496
	i32 30, ; 497
	i32 289, ; 498
	i32 74, ; 499
	i32 223, ; 500
	i32 26, ; 501
	i32 198, ; 502
	i32 211, ; 503
	i32 252, ; 504
	i32 249, ; 505
	i32 306, ; 506
	i32 139, ; 507
	i32 204, ; 508
	i32 220, ; 509
	i32 170, ; 510
	i32 253, ; 511
	i32 285, ; 512
	i32 103, ; 513
	i32 125, ; 514
	i32 224, ; 515
	i32 178, ; 516
	i32 165, ; 517
	i32 169, ; 518
	i32 227, ; 519
	i32 41, ; 520
	i32 185, ; 521
	i32 293, ; 522
	i32 19, ; 523
	i32 173, ; 524
	i32 306, ; 525
	i32 305, ; 526
	i32 139, ; 527
	i32 152, ; 528
	i32 216, ; 529
	i32 192, ; 530
	i32 157, ; 531
	i32 132, ; 532
	i32 21, ; 533
	i32 67, ; 534
	i32 149, ; 535
	i32 49, ; 536
	i32 313, ; 537
	i32 202, ; 538
	i32 81, ; 539
	i32 2, ; 540
	i32 63, ; 541
	i32 108, ; 542
	i32 251, ; 543
	i32 206, ; 544
	i32 51, ; 545
	i32 237, ; 546
	i32 310, ; 547
	i32 248, ; 548
	i32 16, ; 549
	i32 177, ; 550
	i32 70, ; 551
	i32 197, ; 552
	i32 173, ; 553
	i32 212, ; 554
	i32 216, ; 555
	i32 315, ; 556
	i32 80, ; 557
	i32 221, ; 558
	i32 110, ; 559
	i32 205, ; 560
	i32 247, ; 561
	i32 69, ; 562
	i32 65, ; 563
	i32 29, ; 564
	i32 162, ; 565
	i32 214, ; 566
	i32 12, ; 567
	i32 185, ; 568
	i32 13, ; 569
	i32 80, ; 570
	i32 128, ; 571
	i32 85, ; 572
	i32 196, ; 573
	i32 193, ; 574
	i32 179, ; 575
	i32 68, ; 576
	i32 109, ; 577
	i32 67, ; 578
	i32 130, ; 579
	i32 124, ; 580
	i32 79, ; 581
	i32 262, ; 582
	i32 194, ; 583
	i32 252, ; 584
	i32 314, ; 585
	i32 10, ; 586
	i32 220, ; 587
	i32 4, ; 588
	i32 46, ; 589
	i32 265, ; 590
	i32 158, ; 591
	i32 130, ; 592
	i32 250, ; 593
	i32 25, ; 594
	i32 135, ; 595
	i32 208, ; 596
	i32 239, ; 597
	i32 309, ; 598
	i32 291, ; 599
	i32 31, ; 600
	i32 207, ; 601
	i32 64, ; 602
	i32 187, ; 603
	i32 92, ; 604
	i32 89, ; 605
	i32 150, ; 606
	i32 189, ; 607
	i32 38, ; 608
	i32 88, ; 609
	i32 228, ; 610
	i32 304, ; 611
	i32 299, ; 612
	i32 178, ; 613
	i32 52, ; 614
	i32 8, ; 615
	i32 92, ; 616
	i32 311, ; 617
	i32 23, ; 618
	i32 164, ; 619
	i32 98, ; 620
	i32 52, ; 621
	i32 115, ; 622
	i32 244, ; 623
	i32 132, ; 624
	i32 78, ; 625
	i32 29, ; 626
	i32 221, ; 627
	i32 243, ; 628
	i32 9, ; 629
	i32 186, ; 630
	i32 112, ; 631
	i32 244, ; 632
	i32 230 ; 633
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

; Function attributes: "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nofree norecurse nosync nounwind "stack-protector-buffer-size"="8" uwtable willreturn
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

; Function attributes: "no-trapping-math"="true" noreturn nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nofree norecurse nosync nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { "no-trapping-math"="true" noreturn nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }

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
!7 = !{i32 1, !"min_enum_size", i32 4}
