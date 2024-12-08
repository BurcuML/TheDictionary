namespace TheDictionary.Models.Posts;

public sealed record UpdatePostRequestDto(Guid id, string Title, string Content); //burada id almak durumundayız çünkü güncelleme işlemi yaparken id ye bakmamız gerekiyor
                                                                                    //böyle bir post var mı diye kontrol etmek için
