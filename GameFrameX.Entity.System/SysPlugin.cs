﻿// 麻省理工学院许可证
//
// 版权所有 (c) 2021-2023 zuohuaijun，大名科技（天津）有限公司  联系电话/微信：18020030720  QQ：515096995
//
// 特此免费授予获得本软件的任何人以处理本软件的权利，但须遵守以下条件：在所有副本或重要部分的软件中必须包括上述版权声明和本许可声明。
//
// 软件按“原样”提供，不提供任何形式的明示或暗示的保证，包括但不限于对适销性、适用性和非侵权的保证。
// 在任何情况下，作者或版权持有人均不对任何索赔、损害或其他责任负责，无论是因合同、侵权或其他方式引起的，与软件或其使用或其他交易有关。

using GameFrameX.Core.Enum;

namespace GameFrameX.Entity.System;

/// <summary>
/// 系统动态插件表
/// </summary>
[SugarTable(null, "系统动态插件表")]
[SysTable]
[IncreTable]
public class SysPlugin : EntityTenant
{
    /// <summary>
    /// 名称
    /// </summary>
    [SugarColumn(ColumnDescription = "名称", Length = 64)]
    [Required, MaxLength(64)]
    public virtual string Name { get; set; }

    /// <summary>
    /// C#代码
    /// </summary>
    [SugarColumn(ColumnDescription = "C#代码", ColumnDataType = StaticConfig.CodeFirst_BigString)]
    [Required]
    public virtual string CsharpCode { get; set; }

    /// <summary>
    /// 程序集名称
    /// </summary>
    [SugarColumn(ColumnDescription = "程序集名称", Length = 512)]
    [MaxLength(512)]
    public string? AssemblyName { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [SugarColumn(ColumnDescription = "排序")]
    public int OrderNo { get; set; } = 100;

    /// <summary>
    /// 状态
    /// </summary>
    [SugarColumn(ColumnDescription = "状态")]
    public StatusEnum Status { get; set; } = StatusEnum.Enable;

    /// <summary>
    /// 备注
    /// </summary>
    [SugarColumn(ColumnDescription = "备注", Length = 128)]
    [MaxLength(128)]
    public string? Remark { get; set; }
}