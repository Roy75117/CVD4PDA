using System.Reflection;
using System.Runtime.CompilerServices;

//
// 一般的組件資訊是由下列這組屬性所控制。
// 變更這些屬性的值即可修改組件的相關資訊。
//
[assembly: AssemblyTitle("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

//
// 組件的版本資訊由下列四個值所組成:
//
//      主要版本
//      次要版本 
//      組建編號
//      修訂
//
// 您可以自行指定所有的值，也可以依照以下的方式，使用 '*' 將修訂和組建編號
// 指定為預設值:

[assembly: AssemblyVersion("1.0.*")]

//
// 若要簽名組件，您必須指定所要使用的金鑰。
// 如需組件簽名的詳細資訊，請參閱 Microsoft .NET Framework 文件。
//
// 請使用下列屬性來控制哪個金鑰要用來簽名。
//
// 注意: 
//   (*) 如果沒有指定金鑰，將不會簽名組件。
//   (*) KeyName 是指已安裝在電腦上密碼編譯服務提供者 (CSP) 中的金鑰。
//   (*) 如果同時指定了金鑰檔案和金鑰名稱，將會發生下列的處理程序:
//       (1) 如果在 CSP 中可以找到 KeyName，就會使用此金鑰。
//       (2) 如果 KeyName 不存在而 KeyFile 卻存在，就會將 KeyFile 中的金鑰
//           安裝到 CSP 中並加以使用。
//   (*) 延遲簽名是一個進階選項 - 如需詳細資訊，請參閱 Microsoft .NET Framework 文件。
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("")]
[assembly: AssemblyKeyName("")]
