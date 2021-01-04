namespace CharacterCatalog.Core.Constants
{
    public static class CharacterCatalogConsts
    {
        public static class Pagination
        {
            public const int InitialPage = 0;
            public const int DefaultPageSize = 20;
        }

        public static class TempDataKeys
        {
            public const string UploadValidationMessageKey = "ValidationMessage";
        }

        public static class SQLQueries
        {
            public const string CharacterCount = @"SELECT COUNT(*) AS [Count] FROM Character";
            public const string CharactersWithUndefinedTypesCount = @"SELECT COUNT(*) AS [Count] FROM Character WHERE Type = ''";
            public const string MostCommonStatus = @"SELECT Status 
FROM (SELECT Status, MAX(Occurrences) 
FROM (SELECT Status, COUNT(Status) AS [Occurrences] FROM Character GROUP BY Status))";

            public const string StatusStatistics = @"SELECT Status, COUNT(Status) AS [Occurrences] FROM Character GROUP BY Status";
            public const string UniqueTypes = @"SELECT Type FROM Character GROUP BY Type";
            public const string DifferentSpeciesAndTheirOccurrences = @"SELECT s.Name, COUNT(c.SpeciesId) AS [Count] 
FROM Character c
INNER JOIN Species s ON s.SpeciesId = c.SpeciesId
GROUP BY s.SpeciesId";
        }
    }
}
