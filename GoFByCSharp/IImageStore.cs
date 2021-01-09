using System;
using System.Collections.Generic;
using System.Text;

namespace GoFByCSharp
{
    interface IImageStore
    {
        string Upload(Image image, string bucketName);
        Image Download(string url);
    }
}
