$contentPath = $OctopusOriginalPackageDirectoryPath
$fullPath = (Join-Path $OctopusOriginalPackageDirectoryPath "migrate.exe")

Write-Host "Content Path:" $contentPath
Write-Host "Migrate Path:" $fullPath

cd $contentPath
write-host "Working Dir: "$(get-location)

$ApplicationConnectionString = "Data Source=VDW-SQL-001-T1; Initial Catalog=RapporteringsFormulieren; Integrated Security=True; MultipleActiveResultSets=True"

& "$fullPath" Rf.Repositories.dll /startUpConfigurationFile=Web.config /connectionString=$ApplicationConnectionString /connectionProviderName="System.Data.SqlClient" /verbose | Write-Host