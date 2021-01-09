using System;
using System.Collections.Generic;
using System.Text;

namespace GoFByCSharp
{
    class ImageStoreJob
    {
        private static readonly string BUCKET_NAME = "ai_images_bucket";
        //... 省略其他无关代码...
        public void Process()
        {
            Image image = new Image();// 处理图片，并封装为 Image 对象
            //在此处直接调用的私有云的上传，但这样感觉还是体现不出面向接口编程的好处
            IImageStore imageStore = new PrivateImageStore();
            imageStore.Upload(image, BUCKET_NAME);
        }
    }
}
