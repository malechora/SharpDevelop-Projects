/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 13/10/2023
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sad
{
	using System;
	using System.Runtime.InteropServices;
	using Extensibility;


	#region Creating an Add-in for Office ...

	//		First of all, make sure the "Register for COM Interop" flag in your project
	//		options is enabled. Create and add a reference to the Office core
	//				tlbimp %CommonProgramFiles%\Microsoft Shared\Office12\mso.dll
	//					/out:Microsoft.Office.Interop.dll
	//
	//		Then add some code, compile the assembly and register it with
	//				regasm sad.dll
	//
	//
	//		Now create a new Registry key for the Office application, you want to
	//		connect to
	//				HKLM\Software\Microsoft\Visio\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\Word\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\Excel\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\Outlook\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\Publisher\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\Access\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\PowerPoint\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\FrontPage\Addins\sad.Connect
	//				HKLM\Software\Microsoft\Office\MS Project\Addins\sad.Connect
	//
	//		Now create this 3 values
	//				LoadBehavior (DWORD)	= 3
	//				Description  (String)	= a descriptive string for your add-in
	//				FriendlyName (String)	= a name
	//
	//		If you don't want to use your add-in anymore, remove those Registry entries and
	//		unregister the assembly with
	//				regasm sad.dll /u
	//
	//
	//		The best way, doing these registration steps, is a Setup project.

	#endregion


	[GuidAttribute("64A2BC23-A879-454C-892B-B06E5277A14B"), ProgId("sad.Connect")]
	[ComVisible(true)]
	public class Connect : Object, Extensibility.IDTExtensibility2
	{
		public Connect()
		{
		}

		public void OnConnection(object application, ext_ConnectMode ConnectMode, object AddInInst, ref System.Array custom)
		{
			applicationObject = application;
			addinInstance = AddInInst;
		}
		
		public void OnDisconnection(ext_DisconnectMode RemoveMode, ref System.Array custom)
		{
		}
		
		public void OnAddInsUpdate(ref System.Array custom)
		{
		}
		
		public void OnStartupComplete(ref System.Array custom)
		{
		}
		
		public void OnBeginShutdown(ref System.Array custom)
		{
		}

		private object applicationObject;
		private object addinInstance;
	}
}