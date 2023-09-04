﻿using Dashboard.DashboardDomain.Base;

namespace Dashboard.DashboardDomain.Posts;

/// <summary>
///  Сущность объявлений.
/// </summary>
public class Post : BaseEntity
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
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Создатель объявления.
    /// </summary>
    public string Author { get; set; }

    /// <summary>
    /// наименование тегов.
    /// </summary>
    public string[] TagNames { get; set; }

    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }

}
