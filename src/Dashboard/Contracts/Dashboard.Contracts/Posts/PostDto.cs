using Dashboard.Contracts.Base;

namespace Dashboard.Contracts.Posts;

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
    /// наименование тегов.
    /// </summary>
    public string TagName { get; set; }

    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }

}