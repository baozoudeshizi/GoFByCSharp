using System;
using System.Collections.Generic;
using System.Text;

namespace GoFByCSharp
{
    class PrivateImageStore:IImageStore
    {
        //... 省略属性、构造函数等...
        public string Upload(Image image, string bucketName)
        {
            CreateBucketIfNotExisting(bucketName);
            //假设私有云不需要生成Token，则上传实际执行与阿里云上传不一样
            //string accessToken = generateAccessToken();
            //... 上传图片到阿里云...
            //... 返回图片在阿里云上的地址 (url)...
            return string.Empty;
        }
        public Image Download(string url)
        {
            //string accessToken = generateAccessToken(); 
            //... 从阿里云下载图片...
            return new Image();
        }
        private void CreateBucketIfNotExisting(string bucketName)
        {
            // ... 创建 bucket...
            // ... 失败会抛出异常..
        }
    }
}
