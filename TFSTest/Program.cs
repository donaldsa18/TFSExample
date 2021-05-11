using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.Services.Common;
using System;

namespace TFSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = $"https://dev.azure.com/{Properties.Settings.Default.Org}";
            var credentials = new VssBasicCredential("", Properties.Settings.Default.PAT);
            TfsTeamProjectCollection tfs = new TfsTeamProjectCollection(new Uri(url, UriKind.Absolute), credentials);
            var TFSWorkItemStore = new WorkItemStore(tfs);
            var item = TFSWorkItemStore.GetWorkItem(Properties.Settings.Default.Workitem);
            Console.WriteLine($"Created By: {item.CreatedBy}");
            Console.WriteLine($"ID: {item.Id}");
        }
    }
}
