namespace BookHouse.Domain.Abstract;

public abstract class ThePublisher
{
    /// <summary>
    ///     Unique Identifier for the Publisher
    /// </summary>
    protected abstract string IdCodePublisher { get; }

    protected abstract string Name { get; }

    /// <summary>
    ///     Publisher ISBN Prefix
    ///     <br />出版社代碼, 從ISBN中提取
    /// </summary>
    protected abstract string PublisherIdISBN { get; }

    protected abstract TheNation Nation { get; }

    protected abstract string OfficialWebsite { get; }

    protected abstract string Description { get; }

    /// <summary>
    ///     Year the Publisher was Established
    ///     <br />出版社成立年份
    /// </summary>
    protected abstract int EstablishedYear { get; }

    protected abstract string LogoUrl { get; }

    protected abstract string BannerUrl { get; }

    protected abstract IList<TheSocialMedia> SocialMediaLinks { get; }
}