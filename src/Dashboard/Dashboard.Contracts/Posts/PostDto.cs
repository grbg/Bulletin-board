﻿using Dashboard.Contracts.Attachment;
using Dashboard.Dashboard.Contracts.Base;
using System;

namespace Dashboard.Dashboard.Contracts.Posts;

/// <summary>
///  Объявление.
/// </summary>
public class PostDto : BaseDto
{
    /// <summary>
    /// Заголовок.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Наименование категории.
    /// </summary>
    public string CategoryName { get; set; }

    /// <summary>
    /// Создатель объявления.
    /// </summary>
    public string Author { get; set; }

    /// <summary>
    /// Наименование тегов.
    /// </summary>
    public string[] TagNames { get; set; }

    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Изображения.
    /// </summary>
    public IReadOnlyCollection<AttachmentDto> Attachments { get; set; }
}
