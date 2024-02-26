﻿// 麻省理工学院许可证
//
// 版权所有 (c) 2021-2023 zuohuaijun，大名科技（天津）有限公司  联系电话/微信：18020030720  QQ：515096995
//
// 特此免费授予获得本软件的任何人以处理本软件的权利，但须遵守以下条件：在所有副本或重要部分的软件中必须包括上述版权声明和本许可声明。
//
// 软件按“原样”提供，不提供任何形式的明示或暗示的保证，包括但不限于对适销性、适用性和非侵权的保证。
// 在任何情况下，作者或版权持有人均不对任何索赔、损害或其他责任负责，无论是因合同、侵权或其他方式引起的，与软件或其使用或其他交易有关。

namespace GameFrameX.Core.Enum;

/// <summary>
/// 微信开发返回码
/// </summary>
[Description("微信开发返回码")]
public enum WechatReturnCodeEnum
{
    SenparcWeixinSDK配置错误 = -99, // 0xFFFFFF9D
    系统繁忙此时请开发者稍候再试 = -1, // 0xFFFFFFFF
    请求成功 = 0,
    工商数据返回_企业已注销 = 101, // 0x00000065
    工商数据返回_企业不存在或企业信息未更新 = 102, // 0x00000066
    工商数据返回_企业法定代表人姓名不一致 = 103, // 0x00000067
    工商数据返回_企业法定代表人身份证号码不一致 = 104, // 0x00000068
    法定代表人身份证号码_工商数据未更新_请5_15个工作日之后尝试 = 105, // 0x00000069
    工商数据返回_企业信息或法定代表人信息不一致 = 1000, // 0x000003E8
    对方不是粉丝 = 10700, // 0x000029CC
    发送消息失败_对方关闭了接收消息 = 10703, // 0x000029CF
    发送消息失败_48小时内用户未互动 = 10706, // 0x000029D2
    POST参数非法 = 20002, // 0x00004E22
    获取access_token时AppSecret错误或者access_token无效 = 40001, // 0x00009C41

    /// <summary>
    /// <para>公众号：不合法的凭证类型</para>
    /// <para>小程序：暂无生成权限</para>
    /// </summary>
    不合法的凭证类型 = 40002, // 0x00009C42

    不合法的OpenID = 40003, // 0x00009C43
    不合法的媒体文件类型 = 40004, // 0x00009C44
    不合法的文件类型 = 40005, // 0x00009C45
    不合法的文件大小 = 40006, // 0x00009C46
    不合法的媒体文件id = 40007, // 0x00009C47
    不合法的消息类型_40008 = 40008, // 0x00009C48
    不合法的图片文件大小 = 40009, // 0x00009C49
    不合法的语音文件大小 = 40010, // 0x00009C4A
    不合法的视频文件大小 = 40011, // 0x00009C4B
    不合法的缩略图文件大小 = 40012, // 0x00009C4C

    /// <summary>
    /// <para>微信：不合法的APPID</para>
    /// <para>小程序：生成权限被封禁</para>
    /// </summary>
    不合法的APPID = 40013, // 0x00009C4D

    不合法的access_token = 40014, // 0x00009C4E
    不合法的菜单类型 = 40015, // 0x00009C4F
    不合法的按钮个数1 = 40016, // 0x00009C50
    不合法的按钮个数2 = 40017, // 0x00009C51
    不合法的按钮名字长度 = 40018, // 0x00009C52
    不合法的按钮KEY长度 = 40019, // 0x00009C53
    不合法的按钮URL长度 = 40020, // 0x00009C54
    不合法的菜单版本号 = 40021, // 0x00009C55
    不合法的子菜单级数 = 40022, // 0x00009C56
    不合法的子菜单按钮个数 = 40023, // 0x00009C57
    不合法的子菜单按钮类型 = 40024, // 0x00009C58
    不合法的子菜单按钮名字长度 = 40025, // 0x00009C59
    不合法的子菜单按钮KEY长度 = 40026, // 0x00009C5A
    不合法的子菜单按钮URL长度 = 40027, // 0x00009C5B
    不合法的自定义菜单使用用户 = 40028, // 0x00009C5C
    不合法的oauth_code = 40029, // 0x00009C5D
    不合法的refresh_token = 40030, // 0x00009C5E
    不合法的openid列表 = 40031, // 0x00009C5F
    不合法的openid列表长度 = 40032, // 0x00009C60
    不合法的请求字符不能包含uxxxx格式的字符 = 40033, // 0x00009C61
    不合法的参数 = 40035, // 0x00009C63
    template_id不正确 = 40037, // 0x00009C65
    不合法的请求格式 = 40038, // 0x00009C66
    不合法的URL长度 = 40039, // 0x00009C67
    不合法的分组id = 40050, // 0x00009C72
    分组名字不合法 = 40051, // 0x00009C73

    /// <summary>
    /// <para>公众号：输入参数有误</para>
    /// <para>小程序：参数expire_time填写错误</para>
    /// </summary>
    输入参数有误 = 40097, // 0x00009CA1

    appsecret不正确 = 40125, // 0x00009CBD
    调用接口的IP地址不在白名单中 = 40164, // 0x00009CE4
    参数path填写错误 = 40165, // 0x00009CE5
    小程序Appid不存在 = 40166, // 0x00009CE6
    参数query填写错误 = 40212, // 0x00009D14
    缺少access_token参数 = 41001, // 0x0000A029
    缺少appid参数 = 41002, // 0x0000A02A
    缺少refresh_token参数 = 41003, // 0x0000A02B
    缺少secret参数 = 41004, // 0x0000A02C
    缺少多媒体文件数据 = 41005, // 0x0000A02D
    缺少media_id参数 = 41006, // 0x0000A02E
    缺少子菜单数据 = 41007, // 0x0000A02F
    缺少oauth_code = 41008, // 0x0000A030
    缺少openid = 41009, // 0x0000A031
    form_id不正确_或者过期 = 41028, // 0x0000A044
    form_id已被使用 = 41029, // 0x0000A045
    page不正确 = 41030, // 0x0000A046
    access_token超时 = 42001, // 0x0000A411
    refresh_token超时 = 42002, // 0x0000A412
    oauth_code超时 = 42003, // 0x0000A413
    需要GET请求 = 43001, // 0x0000A7F9
    需要POST请求 = 43002, // 0x0000A7FA
    需要HTTPS请求 = 43003, // 0x0000A7FB
    需要接收者关注 = 43004, // 0x0000A7FC
    需要好友关系 = 43005, // 0x0000A7FD

    /// <summary>[小程序订阅消息]用户拒绝接受消息，如果用户之前曾经订阅过，则表示用户取消了订阅关系</summary>
    用户拒绝接受消息 = 43101, // 0x0000A85D

    没有权限 = 43104, // 0x0000A860
    多媒体文件为空 = 44001, // 0x0000ABE1
    POST的数据包为空 = 44002, // 0x0000ABE2
    图文消息内容为空 = 44003, // 0x0000ABE3
    文本消息内容为空 = 44004, // 0x0000ABE4
    多媒体文件大小超过限制 = 45001, // 0x0000AFC9
    消息内容超过限制 = 45002, // 0x0000AFCA
    标题字段超过限制 = 45003, // 0x0000AFCB
    描述字段超过限制 = 45004, // 0x0000AFCC
    链接字段超过限制 = 45005, // 0x0000AFCD
    图片链接字段超过限制 = 45006, // 0x0000AFCE
    语音播放时间超过限制 = 45007, // 0x0000AFCF
    图文消息超过限制 = 45008, // 0x0000AFD0
    接口调用超过限制 = 45009, // 0x0000AFD1
    创建菜单个数超过限制 = 45010, // 0x0000AFD2
    回复时间超过限制 = 45015, // 0x0000AFD7
    系统分组不允许修改 = 45016, // 0x0000AFD8
    分组名字过长 = 45017, // 0x0000AFD9
    分组数量超过上限 = 45018, // 0x0000AFDA
    超出响应数量限制 = 45047, // 0x0000AFF7
    创建的标签数过多请注意不能超过100个 = 45056, // 0x0000B000
    标签名非法请注意不能和其他标签重名 = 45157, // 0x0000B065
    标签名长度超过30个字节 = 45158, // 0x0000B066
    不存在媒体数据 = 46001, // 0x0000B3B1
    不存在的菜单版本 = 46002, // 0x0000B3B2
    不存在的菜单数据 = 46003, // 0x0000B3B3
    解析JSON_XML内容错误 = 47001, // 0x0000B799

    /// <summary>[小程序订阅消息]模板参数不准确，可能为空或者不满足规则，errmsg会提示具体是哪个字段出错</summary>
    模板参数不准确 = 47003, // 0x0000B79B

    api功能未授权 = 48001, // 0x0000BB81
    用户未授权该api = 50001, // 0x0000C351
    名称格式不合法 = 53010, // 0x0000CF12
    名称检测命中频率限制 = 53011, // 0x0000CF13
    禁止使用该名称 = 53012, // 0x0000CF14
    公众号_名称与已有公众号名称重复_小程序_该名称与已有小程序名称重复 = 53013, // 0x0000CF15
    公众号_公众号已有_名称A_时_需与该帐号相同主体才可申请_名称A_小程序_小程序已有_名称A_时_需与该帐号相同主体才可申请_名称A_ = 53014, // 0x0000CF16
    公众号_该名称与已有小程序名称重复_需与该小程序帐号相同主体才可申请_小程序_该名称与已有公众号名称重复_需与该公众号帐号相同主体才可申请 = 53015, // 0x0000CF17
    公众号_该名称与已有多个小程序名称重复_暂不支持申请_小程序_该名称与已有多个公众号名称重复_暂不支持申请 = 53016, // 0x0000CF18
    公众号_小程序已有_名称A_时_需与该帐号相同主体才可申请_名称A_小程序_公众号已有_名称A_时_需与该帐号相同主体才可申请_名称A = 53017, // 0x0000CF19
    名称命中微信号 = 53018, // 0x0000CF1A
    名称在保护期内 = 53019, // 0x0000CF1B
    法人姓名与微信号不一致 = 61070, // 0x0000EE8E
    系统错误system_error = 61450, // 0x0000F00A
    参数错误invalid_parameter = 61451, // 0x0000F00B
    无效客服账号invalid_kf_account = 61452, // 0x0000F00C
    客服帐号已存在kf_account_exsited = 61453, // 0x0000F00D

    /// <summary>
    /// 客服帐号名长度超过限制(仅允许10个英文字符，不包括@及@后的公众号的微信号)(invalid kf_acount length)
    /// </summary>
    客服帐号名长度超过限制 = 61454, // 0x0000F00E

    /// <summary>
    /// 客服帐号名包含非法字符(仅允许英文+数字)(illegal character in kf_account)
    /// </summary>
    客服帐号名包含非法字符 = 61455, // 0x0000F00F

    /// <summary>客服帐号个数超过限制(10个客服账号)(kf_account count exceeded)</summary>
    客服帐号个数超过限制 = 61456, // 0x0000F010

    无效头像文件类型invalid_file_type = 61457, // 0x0000F011
    日期格式错误 = 61500, // 0x0000F03C
    日期范围错误 = 61501, // 0x0000F03D
    发送消息失败_该用户已被加入黑名单_无法向此发送消息 = 62751, // 0x0000F51F
    门店不存在 = 65115, // 0x0000FE5B
    该门店状态不允许更新 = 65118, // 0x0000FE5E
    标签格式错误 = 85006, // 0x00014C0E
    页面路径错误 = 85007, // 0x00014C0F
    类目填写错误 = 85008, // 0x00014C10
    已经有正在审核的版本 = 85009, // 0x00014C11
    item_list有项目为空 = 85010, // 0x00014C12
    标题填写错误 = 85011, // 0x00014C13
    无效的审核id = 85012, // 0x00014C14
    版本输入错误 = 85015, // 0x00014C17
    没有审核版本 = 85019, // 0x00014C1B
    审核状态未满足发布 = 85020, // 0x00014C1C
    状态不可变 = 85021, // 0x00014C1D
    action非法 = 85022, // 0x00014C1E
    审核列表填写的项目数不在1到5以内 = 85023, // 0x00014C1F
    需要补充相应资料_填写org_code和other_files参数 = 85024, // 0x00014C20
    管理员手机登记数量已超过上限 = 85025, // 0x00014C21
    该微信号已绑定5个管理员 = 85026, // 0x00014C22
    管理员身份证已登记过5次 = 85027, // 0x00014C23
    该主体登记数量已超过上限 = 85028, // 0x00014C24
    商家名称已被占用 = 85029, // 0x00014C25
    不能使用该名称 = 85031, // 0x00014C27
    该名称在侵权投诉保护期 = 85032, // 0x00014C28
    名称包含违规内容或微信等保留字 = 85033, // 0x00014C29
    商家名称在改名15天保护期内 = 85034, // 0x00014C2A
    需与该帐号相同主体才可申请 = 85035, // 0x00014C2B
    介绍中含有虚假混淆内容 = 85036, // 0x00014C2C
    头像或者简介修改达到每个月上限 = 85049, // 0x00014C39
    正在审核中_请勿重复提交 = 85050, // 0x00014C3A
    请先成功创建门店后再调用 = 85053, // 0x00014C3D
    临时mediaid无效 = 85056, // 0x00014C40
    链接错误 = 85066, // 0x00014C4A
    测试链接不是子链接 = 85068, // 0x00014C4C
    校验文件失败 = 85069, // 0x00014C4D
    个人类型小程序无法设置二维码规则 = 85070, // 0x00014C4E
    已添加该链接_请勿重复添加 = 85071, // 0x00014C4F
    该链接已被占用 = 85072, // 0x00014C50
    二维码规则已满 = 85073, // 0x00014C51
    小程序未发布_小程序必须先发布代码才可以发布二维码跳转规则 = 85074, // 0x00014C52
    个人类型小程序无法设置二维码规则1 = 85075, // 0x00014C53
    小程序没有线上版本_不能进行灰度 = 85079, // 0x00014C57
    小程序提交的审核未审核通过 = 85080, // 0x00014C58
    无效的发布比例 = 85081, // 0x00014C59
    当前的发布比例需要比之前设置的高 = 85082, // 0x00014C5A
    小程序提审数量已达本月上限 = 85085, // 0x00014C5D
    提交代码审核之前需提前上传代码 = 85086, // 0x00014C5E
    小程序已使用_api_navigateToMiniProgram_请声明跳转_appid_列表后再次提交 = 85087, // 0x00014C5F
    不是由第三方代小程序进行调用 = 86000, // 0x00014FF0
    不存在第三方的已经提交的代码 = 86001, // 0x00014FF1
    小程序还未设置昵称_头像_简介_请先设置完后再重新提交 = 86002, // 0x00014FF2
    无效微信号 = 86004, // 0x00014FF4

    /// <summary>
    /// 小程序为“签名错误”。对应公众号： 87009, “errmsg” : “reply is not exists” //该回复不存在
    /// </summary>
    签名错误 = 87009, // 0x000153E1

    现网已经在灰度发布_不能进行版本回退 = 87011, // 0x000153E3
    该版本不能回退_可能的原因_1_无上一个线上版用于回退_2_此版本为已回退版本_不能回退_3_此版本为回退功能上线之前的版本_不能回退 = 87012, // 0x000153E4
    内容含有违法违规内容 = 87014, // 0x000153E6
    没有留言权限 = 88000, // 0x000157C0
    该图文不存在 = 88001, // 0x000157C1
    文章存在敏感信息 = 88002, // 0x000157C2
    精选评论数已达上限 = 88003, // 0x000157C3
    已被用户删除_无法精选 = 88004, // 0x000157C4
    已经回复过了 = 88005, // 0x000157C5
    回复超过长度限制或为0 = 88007, // 0x000157C7
    该评论不存在 = 88008, // 0x000157C8
    获取评论数目不合法 = 88010, // 0x000157CA
    该公众号_小程序已经绑定了开放平台帐号 = 89000, // 0x00015BA8
    业务域名无更改_无需重复设置 = 89019, // 0x00015BBB
    尚未设置小程序业务域名_请先在第三方平台中设置小程序业务域名后在调用本接口 = 89020, // 0x00015BBC
    请求保存的域名不是第三方平台中已设置的小程序业务域名或子域名 = 89021, // 0x00015BBD
    业务域名数量超过限制_最多可以添加100个业务域名 = 89029, // 0x00015BC5
    个人小程序不支持调用_setwebviewdomain_接口 = 89231, // 0x00015C8F
    内部错误 = 89247, // 0x00015C9F
    企业代码类型无效_请选择正确类型填写 = 89248, // 0x00015CA0
    该主体已有任务执行中_距上次任务24h后再试 = 89249, // 0x00015CA1
    未找到该任务 = 89250, // 0x00015CA2
    待法人人脸核身校验 = 89251, // 0x00015CA3
    法人_企业信息一致性校验中 = 89252, // 0x00015CA4
    缺少参数 = 89253, // 0x00015CA5
    第三方权限集不全_补全权限集全网发布后生效 = 89254, // 0x00015CA6
    系统不稳定_请稍后再试_如多次失败请通过社区反馈 = 89401, // 0x00015D39
    该审核单不在待审核队列_请检查是否已提交审核或已审完 = 89402, // 0x00015D3A
    本单属于平台不支持加急种类_请等待正常审核流程 = 89403, // 0x00015D3B
    本单已加速成功_请勿重复提交 = 89404, // 0x00015D3C
    本月加急额度不足_请提升提审质量以获取更多额度 = 89405, // 0x00015D3D
    该经营资质已添加_请勿重复添加 = 92000, // 0x00016760
    附近地点添加数量达到上线_无法继续添加 = 92002, // 0x00016762
    地点已被其它小程序占用 = 92003, // 0x00016763
    附近功能被封禁 = 92004, // 0x00016764
    地点正在审核中 = 92005, // 0x00016765
    地点正在展示小程序 = 92006, // 0x00016766
    地点审核失败 = 92007, // 0x00016767
    程序未展示在该地点 = 92008, // 0x00016768
    小程序未上架或不可见 = 92009, // 0x00016769
    地点不存在 = 93010, // 0x00016B52
    个人类型小程序不可用 = 93011, // 0x00016B53
    已下发的模板消息法人并未确认且已超时_24h_未进行身份证校验 = 100001, // 0x000186A1
    已下发的模板消息法人并未确认且已超时_24h_未进行人脸识别校验 = 100002, // 0x000186A2
    已下发的模板消息法人并未确认且已超时_24h = 100003, // 0x000186A3
    此账号已被封禁_无法操作 = 200011, // 0x00030D4B
    私有模板数已达上限_上限_50_个 = 200012, // 0x00030D4C
    此模版已被封禁_无法选用 = 200013, // 0x00030D4D
    模版tid参数错误 = 200014, // 0x00030D4E
    关键词列表kidList参数错误 = 200020, // 0x00030D54
    场景描述sceneDesc参数错误 = 200021, // 0x00030D55
}