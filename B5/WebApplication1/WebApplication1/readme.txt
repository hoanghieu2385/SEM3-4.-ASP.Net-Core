chạy cả các lệnh sau trong package manager console:

cd đến project

Xử lý lỗi không nhận diện dotnet-ef:
dotnet tool install --global dotnet-ef


dotnet ef migrations add InitialCreate

dotnet ef database update