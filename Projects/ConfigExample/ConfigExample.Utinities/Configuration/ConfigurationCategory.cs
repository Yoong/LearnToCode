/**************************************************************

* Copyright (C) 2013 
* All Rights Reserved
* Created by Yoong <QQ:806505010>
* 版权所有：Yoong
* 作    者：Yoong(fb2010@live.cn)
* 创建时间：2013-03-13
* 修 改 人：
* 修改内容：
* 修改时间：

**************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigExample.Utinities.Configuration
{
    public enum ConfigurationCateGory
    {
        RegistryKey,  //从注册表读取
        Configuration,//从配置文件读取
        UserConfig//用户的配置文件
    }
}
