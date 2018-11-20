﻿using System;

namespace User.API.Models
{
    public class BPfile
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 上传文件地址
        /// </summary>
        public string OriginFilePath { get; set; }
        /// <summary>
        /// 格式转化后的文件地址
        /// </summary>
        public string FromatFilePath { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
    }
}
