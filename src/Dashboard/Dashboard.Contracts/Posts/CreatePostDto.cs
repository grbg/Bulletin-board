using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Attributes;
using Dashboard.Dashboard.Contracts.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Dashboard.Contracts.Posts;

/// <summary>
///  Объявление.
/// </summary>
public class CreatePostDto : IValidatableObject
{
    /// <summary>
    /// Заголовок.
    /// </summary>
    [Required]
    [StringLength(20, ErrorMessage = "Строка поля {0} должна быть по длине не больше 20 символов")]
    public string Title { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    [Required]
    public string Description { get; set; }

    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Создатель объявления.
    /// </summary>
    public string Author { get; set; }

    /// <summary>
    /// Наименование тегов.
    /// </summary>
    [TagsSize(3, ErrorMessage = "Неверная длина массива. Длина массива должна быть больше 3.")]
    public string[] TagNames { get; set; }

    /// <summary>
    /// Цена.
    /// </summary>
    [Range(0, 10000, ErrorMessage = "Поле {0} должно быть больше {1} и меньше {2}")]
    public decimal Price { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var validationResult = new List<ValidationResult>();

        var badWordsVocabulaty = new string[]
        {
            "блин",
            "котлета",
            "оладушек"
        };

       if(badWordsVocabulaty.Any(x => Description.Contains(x)))
        {
            validationResult.Add(new ValidationResult("Поле Description содержит ценензурную лексику."));
        }
        return validationResult;
    }
}
