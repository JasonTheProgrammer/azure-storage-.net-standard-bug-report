using Microsoft.WindowsAzure.Storage.File;
using System;
using System.Threading.Tasks;

namespace NetStandardLibrary
{
    public class TestClass
    {
        public async Task TestMethod()
        {
            CloudFileDirectory cfd = new CloudFileDirectory(null);
            cfd.ListFilesAndDirectoriesSegmentedAsync(new FileContinuationToken()).Wait();

            await cfd.ListFilesAndDirectoriesSegmentedAsync(
                prefix: "metadata",
                maxResults: 10,
                currentToken: new FileContinuationToken(),
                options: null,
                operationContext: null);
        }
    }
}
