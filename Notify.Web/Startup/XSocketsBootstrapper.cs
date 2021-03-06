using System.Web;
using Notify.Web.Startup;
using XSockets.Core.Common.Socket;

[assembly: PreApplicationStartMethod(typeof(XSocketsBootstrapper), "Start")]

namespace Notify.Web.Startup
{
	public static class XSocketsBootstrapper
	{
		private static IXSocketServerContainer _wss;

		public static void Start()
		{
			_wss = XSockets.Plugin.Framework.Composable.GetExport<IXSocketServerContainer>();
			_wss.StartServers();
		}
	}
}
