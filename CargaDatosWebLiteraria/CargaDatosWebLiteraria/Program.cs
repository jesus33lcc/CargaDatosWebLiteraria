using Gnoss.ApiWrapper;

internal class Program
{
    private static void Main(string[] args)
    {
        string pathOAuth = @"Config\oAuth.config";
        ResourceApi mResourceApi = new ResourceApi(Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, pathOAuth));
        CommunityApi mCommunityApi = new CommunityApi(Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, pathOAuth));
        ThesaurusApi mThesaurusApi = new ThesaurusApi(Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, pathOAuth));
        UserApi mUserApi = new UserApi(Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, pathOAuth));

        Console.WriteLine($"Id de la Comunidad -> {mCommunityApi.GetCommunityId()}");
        Console.WriteLine($"Nombre de la Comunidad -> {mCommunityApi.GetCommunityInfo().name}");
        Console.WriteLine($"Nombre Corto de la Comunidad -> {mCommunityApi.GetCommunityInfo().short_name}");
        Console.WriteLine($"Descripción de la comunidad inicial -> {mCommunityApi.GetCommunityInfo().description}");
    }
}