﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2018 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2018 Senparc
    
    文件名：ListResultJson.cs
    文件功能描述：查看指定文章的评论数据 返回结果
    
    
    创建标识：Senparc - 20180131

    修改标识：Senparc - 20180318
    修改描述：v14.10.6 完善“查看指定文章的评论数据”接口（CommentApi.List()）的返回结果数据
    
----------------------------------------------------------------*/


using Senparc.Weixin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.MP.AdvancedAPIs.Comment.CommentJson
{
    /// <summary>
    /// 查看指定文章的评论数据 返回结果
    /// </summary>
    public class ListResultJson : WxJsonResult
    {
        public ListResultJson_comment[] comment { get; set; }

        /// <summary>
        /// 总数，非comment的size around
        /// </summary>
        public int total { get; set; }

    }

    public class ListResultJson_comment
    {
        /* 
         * 返回结果：
           {
            "user_comment_id": 9,
            "create_time": 1521255525,
            "content": "如果有什么大考验的话可能会发现自己啥都没改都白扯了吧",
            "comment_type": 0,
            "openid": "oufSm0Xw0nhuha_nWD6AfiZ3rgvA"
            }
        */

        public int user_comment_id { get; set; }
        public long create_time { get; set; }
        public string content { get; set; }
        public int comment_type { get; set; }
        public string openid { get; set; }
    }
}