# SquareAgencyProject
Square Agency Project / Kare Ajans Projesi

Projenin migrate kurulumu için şu kodları giriniz;

dotnet ef migrations add "initDb" -c "AuthDbContext"
dotnet ef database update -c "AuthDbContext"

dotnet ef migrations add "initDb" -c "AgencyContext"
dotnet ef database update -c "AgencyContext"

