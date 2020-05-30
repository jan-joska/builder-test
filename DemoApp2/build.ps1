
Get-ChildItem -Path output -Include *.* -Recurse | foreach { $_.Delete()}
dotnet restore
dotnet test -c Release --blame
dotnet build -c Release -o output