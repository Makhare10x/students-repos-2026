// 1. განვსაზღვროთ უნივერსალური ფუნქცია
function loadComponent(url, placeholderId) {
  fetch(url)
    .then((response) => {
      if (!response.ok) throw new Error(`ვერ მოიძებნა ფაილი: ${url}`);
      return response.text();
    })
    .then((data) => {
      const element = document.getElementById(placeholderId);
      if (element) {
        element.innerHTML = data;
      }
    })
    .catch((err) => console.error(`შეცდომა ${url} ჩატვირთვისას:`, err));
}

// 2. გამოვიძახოთ ფუნქცია ყველა საჭირო კომპონენტისთვის
document.addEventListener("DOMContentLoaded", () => {
  loadComponent("header.html", "header-placeholder");
  loadComponent("sidebar.html", "sidebar-placeholder");
  loadComponent("navbar.html", "navbar-placeholder");
  loadComponent("footer.html", "footer-placeholder"); 
});
