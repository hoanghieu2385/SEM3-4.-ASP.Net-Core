# SEM3-4.-ASP.Net-Core
Chuẩn bị cho môn: asp .net core theo mô hình MVC (Môn quan trọng)

- cài đặt visual studio
- SQL server:
    + Azure data studio --------------------- ( FREE )
    + Data grid ------------------------------( Mất phí 💲 )
    + SSMS (SQL Server Management Studio) --- ( FREE )

------------------------------------------------
Buổi 1:

- Tìm hiểu nuget packages

- Key note: 
    + performance
    + object mapper
    + razor

- cách cài nuget:
    + cài bằng terminal: lên trang nuget xong tìm package cần cài rồi copy: Tool -> NuGet Package Manager -> Package Manager Console -> *cd đến project thì mới cài được*
    + cài bằng client:  Tool -> NuGet Package Manager -> Manage NuGet Packages Solution... 

- Làm trong dự án để mọi người cài cùng các package thì ng clone về sẽ sài lệnh: re store

- hàm huỷ trong c#: ~TênClass() ->> nhưng ít cần vì c# tự động dọn dẹp bộ nhớ (GC - Garbage Collector)

- tìm hiểu các phím tắt strong VS: f5, shift f5, f9, f10, shift f10, f11, shift f11
    + F5: *chạy* debug hoặc chạy (continue) tiếp code
    + Shift + F5: *Dừng* Debug
    + F9: *Đặt hoặc xoá* 1 breakpoint ở dòng code hiện tại
    + F10: Bước qua (*step over*): thực hiện đoạn mã mà không đi qua bất kì phương thức nào được gọi
    + Shift + F10: Bước ra (*step out*): thực hiện các bước mã cho đến khi kết thúc phương thức hiện tại
    + F11: Bước vào (*step info*): thực hiện 1 bước code, nếu có phương thức nào được gọi thì sẽ được đi vào phương thức đó
    + Shift + F11: Bước qua (*step over*) trong quá trình debug *giống F10*: nếu đang ở cuối phương thức thì sẽ thoát khỏi phương thức đó
    
- tạo controller: chuột phải trong solution explorer -> add -> controller
- tạo view kiểu tự sinh code: trong hàm tạo (dòng 7 -> 10) -> chuột phải -> add view... -> chọn kiểu view cần chọn

- ta có thể sửa đổi url thấy bằng cách:
{
 
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
            [HttpGet("detail")]     <------
            public IActionResult Detail()
            {
                return View();
            }
        }
    }
    
}


- hot reload: sửa lại giao diện thì ấn vào giúp load lại mà không cần phải chạy lại debug -> giúp tích kiệm thời gian

- tìm hotkey hay dùng trên visual studio

- tổng kết buổi học:
    + Nuget  
    + create project
    + controller
    + view
    + layout
    + routes
    
------------------------------------------------





------------------------------------------------





------------------------------------------------





------------------------------------------------




------------------------------------------------
