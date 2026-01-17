namespace BookHouse.Domain.Abstract;

/// <summary>
///     Abstract representation of a Contributor entity,
///     <br />包含貢獻者的基本資訊與相關實體
/// </summary>
public abstract class TheContributor
{
    protected abstract string IdCodePerson { get; }

    protected abstract string Title { get; }

    protected abstract string FirstName { get; }

    protected abstract string MiddleName { get; }

    protected abstract string LastName { get; }

    protected abstract GenderType Gender { get; }

    protected abstract IList<ContributorRoleType> RoleType { get; }

    protected abstract IList<TheSocialMedia> SocialMediaLinks { get; }

    protected abstract string PhotoUrl { get; }

    protected abstract string Description { get; }
}