using System;
using System.Collections.Generic;
using System.Text;

namespace GoFByCSharp
{
    class AliyunImageStore:IImageStore
    {
        //... 省略属性、构造函数等...
        public string Upload(Image image, string bucketName)
        {
            createBucketIfNotExisting(bucketName);
            string accessToken = generateAccessToken();
            //... 上传图片到阿里云...
            //... 返回图片在阿里云上的地址 (url)...
            return string.Empty;
        }
        public Image Download(string url)
        {
            string accessToken = generateAccessToken();
            //... 从阿里云下载图片...
            return new Image();
        }
        private void createBucketIfNotExisting(string bucketName)
        {
            // ... 创建 bucket...
            // ... 失败会抛出异常..
        }
        private string generateAccessToken()
        {
            // ... 根据 accesskey/secrectkey 等生成 access token
            return string.Empty;
        }
    }
}
