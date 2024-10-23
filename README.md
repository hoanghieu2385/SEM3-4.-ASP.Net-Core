# SEM3-4.-ASP.Net-Core

Chuẩn bị cho môn: asp .net core theo mô hình MVC (Môn quan trọng)

- cài đặt visual studio
- SQL server:
  - Azure data studio --------------------- ( FREE )
  - Data grid ------------------------------( Mất phí 💲 )
  - SSMS (SQL Server Management Studio) --- ( FREE )

---

### Buổi 1: tạo project đơn giản

- Tìm hiểu nuget packages

- Key note:

  - performance
  - object mapper
  - razor

- cách cài nuget:

  - cài bằng terminal: lên trang nuget xong tìm package cần cài rồi copy: Tool -> NuGet Package Manager -> Package Manager Console -> _cd đến project thì mới cài được_
  - cài bằng client: Tool -> NuGet Package Manager -> Manage NuGet Packages Solution...

- Làm trong dự án để mọi người cài cùng các package thì ng clone về sẽ sài lệnh: re store

- hàm huỷ trong c#: ~TênClass() ->> nhưng ít cần vì c# tự động dọn dẹp bộ nhớ (GC - Garbage Collector)

- tìm hiểu các phím tắt strong VS: f5, shift f5, f9, f10, shift f10, f11, shift f11
  - F5: **chạy** debug hoặc chạy (continue) tiếp code
  - Shift + F5: **Dừng** Debug
  - F9: **Đặt hoặc xoá** 1 breakpoint ở dòng code hiện tại
  - F10: Bước qua (**step over**): thực hiện đoạn mã mà không đi qua bất kì phương thức nào được gọi
  - Shift + F10: Bước ra (**step out**): thực hiện các bước mã cho đến khi kết thúc phương thức hiện tại
  - F11: Bước vào (**step info**): thực hiện 1 bước code, nếu có phương thức nào được gọi thì sẽ được đi vào phương thức đó
  - Shift + F11: Bước qua (**step over**) trong quá trình debug **giống F10**: nếu đang ở cuối phương thức thì sẽ thoát khỏi phương thức đó
- tạo controller: chuột phải trong solution explorer -> add -> controller
- tạo view kiểu tự sinh code: trong hàm tạo (dòng 7 -> 10) -> chuột phải -> add view... -> chọn kiểu view cần chọn

    <details>
    <summary><strong>ta có thể sửa đổi url thấy bằng cách ấn vào đây để xem:</strong></summary>

        using Microsoft.AspNetCore.Mvc;

      namespace WebApplication1.Controllers

      {
          [Route("/product2")]        <------ hoặc  [Route("product2")] đều thấy chạy bth
          public class ProductController : Controller
          {
              public IActionResult Index()
              {
                  return View();
              }
              [HttpGet("detail")]     <------ cần dòng này để lấy trang detail khi đổi sang tên route mới
              public IActionResult Detail()
              {
                  return View();
              }
          }
      }

    </details>

- Cách thêm button link ở header trong file layout:

      <li class="nav-item">
          <a class="nav-link text-dark" asp-area="" asp-controller="Classes" asp-action="Index">Class</a>
      </li>

      // classes là controller, tên đầy đủ là ClassesController.cs ?? Hoặc là tên folder?????
      // Index là trong folder View -> Index.cshtml <hoặc đổi thành file muốn hiển thị tuỳ ý>

- hot reload: sửa lại giao diện thì ấn vào giúp load lại mà không cần phải chạy lại debug -> giúp tích kiệm thời gian

- tìm hotkey hay dùng trên visual studio

- tổng kết buổi học:
  - Nuget
  - create project
  - controller
  - view
  - layout
  - routes

---

### Buổi 2: kết nối project với database

- Entity framework là gì?

- chuẩn bị, cài trước các nuget:

  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.EntityFrameworkCore.SqlServer

- các bước tạo project:

  1.  tạo ra 1 file class.cs trong Models:

          public class Class
          {
              public int Id { get; set; }
              public string ClassName { get; set; }
          }

  2.  tạo ra 1 file EduDbContext ở ngoài, kế thừa DbContext
      bên trong gõ override OnConfiguring -> tab -> tự gen ra code
      override OnModelCreating -> tab -> tự gen ra code

          <details>
          <summary><strong>hoặc ấn vào đây và copy đoạn sau:</strong></summary>

              protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              {
                  base.OnConfiguring(optionsBuilder);
              }

              protected override void OnModelCreating(ModelBuilder modelBuilder)
              {
                  base.OnModelCreating(modelBuilder);
              }

          </details>

  3.  thêm đoạn code sau vào đầu class EduDbContext:

            public EduDbContext() : base()
            {

            }

            public EduDbContext(DbContextOptions<EduDbContext> options) : base(options)
            {

            }

  4.  rồi thêm dòng:

            modelBuilder.Entity<Class>();

      ở trong **OnModelCreating** để được đoạn như sau:

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
              base.OnModelCreating(modelBuilder);
              modelBuilder.Entity<Class>();
          }

  5.  thêm dòng code sau vào trong class EduDbContext:

      public DbSet<Class> classes { get; set; }

      <details>
      <summary><strong>để được đoạn class như sau: </strong></summary>

          public class EduDbContext : DbContext
          {
              protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              {
                  base.OnConfiguring(optionsBuilder);
              }

              protected override void OnModelCreating(ModelBuilder modelBuilder)
              {
                  base.OnModelCreating(modelBuilder);
                  modelBuilder.Entity<Class>();
              }

              public DbSet<Class> classes { get; set; }

          }

      </details>

  6.  Create Database: vào ssms -> connect -> new query:

          CREATE DATABASE TenDatabase

  7.  sau đó vào file **Program.cs** để thêm chuỗi kết nối:

      - đổi kiểu viết thành main:

            Để con trỏ chuột ở dòng đầu tiên
            -> ấn vào hình bóng đèn (hoặc dùng phím tắt alt + enter hoặc ctrl + .)
            -> chọn convert to 'Program.Main' style program

      - sửa đoạn code:

            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();

      thành:

          var builder = WebApplication.CreateBuilder(args);
          string connectionString = "Server=localhost\\SQLEXPRESS;Database=democonnect;Trusted_Connection=True;TrustServerCertificate=True;";
          // Add services to the container.
          builder.Services.AddControllersWithViews();
          builder.Services.AddDbContext<EduDbContext>(options => options.UseSqlServer(connectionString));

      đoạn connectionString lấy dựa trên trang https://www.connectionstrings.com/sql-server/. sau đó lựa chọn đoạn mã phù hợp

      \*\*\* lưu ý trong ssms khi kết nối thì cần trust server certificate không thì sẽ bị lỗi kết nối

  8.  chạy các lệnh sau để update db trong terminal:

          cd đến project

      Xử lý lỗi không nhận diện dotnet-ef:

          dotnet tool install --global dotnet-ef

      về sau chỉ cần chạy 2 lệnh dưới đây nếu đã chạy lệnh ở trên 1 lần:

          dotnet ef migrations add CaiNayCanDoiSauMoiLanChay
          dotnet ef database update

  9.  tạo trang CURD nhanh:

          chuột phải folder controller -> add -> Controller...
          -> chọn MVC Controller with views, using Entity Framework -> Add
          -> Chọn Model class cần tạo -> xem có cần chỉnh tên không -> Add

---

### Buổi 3:

- Html Helper
- Tìm hiểu luồng code
- Tạo thêm 1 controller student bằng cách tự code
- Tương tác từ controller tới model, từ controller tới view
- Từ controller -> view:
  1. Cách 1: Strongly typed
  2. Cách 2: View Bag
  3. Cách 3: View Data
  4. TempData <Ít dùng>
- Điểm khác giữa View Data và view Bag
  - View Data:
    - Dictionary (Dấu hiệu : Key - Value)
  - View Bag
    - Object (dấu hiệu là dấu .)

---

### Buổi 4:

- DTO (Data transfer object)
- Relation ship

---

### Buổi 5:

- Layout (tìm hiểu và thử áp dụng các template)
- view start.cshtml
- Annotations <trong sách có, tìm hiểu>
- security, authentication <khi tạo project cũng có thể tạo được luôn, tìm hiểu để áp dụng bên ngoài vào >
- Partial views
-
-
- BTVN:
  - tạo 1 layout mới
  - áp dụng template

## \*\* không bỏ @RenderBody() trong Layout <vì nếu bỏ đi sẽ không render được body của trang>

### Buổi 6:

- Viết store procedure
- tạo model StudentReport
- DbContext thêm StudentReport.hasnoekey()
- controller call store procedure
- mapper -> view
- tạo view

<details>
      <summary><strong>để được đoạn store procedure như sau: </strong></summary>

    USE SEM3_EDU;
    GO

    CREATE PROCEDURE GetAllStudent
    AS
    BEGIN
        SELECT a.StudentId,
            b.Name AS StudentName,
            b.Age,
            b.Address,
            a.CourseId,
            c.Name AS CourseName,
            d.ClassName
        FROM dbo.StudentCourse a
        LEFT JOIN dbo.Students b ON b.id = a.StudentId
        LEFT JOIN dbo.Courses c ON c.Id = a.CourseId
        LEFT JOIN dbo.Classes d ON d.Id = b.ClassId;
    END;
    GO

    EXEC GetAllStudent;
    GO

</details>

---

### Buổi 7:

- Action
  - IActionResult
  - File result
- API:
  - restful API -> json/xml
  - SOAP -> xml
- Tạo area
- onion architecture
- Clean Architecture
- Cách tạo Area:

  - tạo project asp.net core
  - tạo folder tên areas
  - click chuột phải vào folder areas và chọn add -> MVC Area -> đặt tên area
  - tạo controller mới và thêm vào cách phần cần thiết:

          [Area("Admin")]
          [Route("Home")]
          [HttpGet("")]

    ở trong controller để được đoạn sau:

          namespace AreaDemo.Areas.Admin.Controllers
          {
              [Area("Admin")]                <====
              [Route("Home")]                <====
              public class HomeController : Controller
              {
                  // GET: HomeController
                  [HttpGet("")]                <====
                  public ActionResult Index()
                  {
                      return View();
                  }
              ... code còn lại
              }
          ... code còn lại
          }

  * copy code trong ScaffoldingReadMe.txt và thêm vào trong file program.cs, thêm vào trước app.Run();
  * đã hoàn thành, thử chạy vào /admin/home thử
  * còn muốn add button vào trên header thì vào view -> shared -> \_layout.cshtml và thêm đoạn sau:

        <li class="nav-item">
            <a class="nav-link text-dark" asp-area="Admin" asp-controller="Home" asp-action="Index">Admin</a>
        </li>

    chú ý là cần chỉ rõ tới area: asp-area="Admin"

- Cách tạo Project Web API

  - tạo new project -> tìm api và chọn web api
  - tạo model Product
  - tạo ProductController -> ở phần get:

        public IEnumerable<Product> Get()
        {
        List<Product> products = new List<Product>();
        products.Add(new Product()
        {
        Id = 1,
        Name = "Iphone 13",
        Description = "Old Product"
        });
        products.Add(new Product()
        { Id = 2,
        Name = "Iphone 16",
        Description = "New Product"
        });
        return products;
        }

- API database:

  - connect như bình thường
  - trong controller:

    - khai báo biến, constructor:

       private readonly EduDbContext context;
       public StudentController(EduDbContext context)
       {
       this.context = context;
       }

    - chỉnh sửa lại phần get thành:

        public IEnumerable<Student> Get()
        {
        List<Student> students = new List<Student>();
        students = this.context.Students.ToList();

              return students;

      }

### Buổi 8:
