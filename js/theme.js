const btn = document.querySelector(".switch");
const theme = document.querySelector("#theme-link");
btn.addEventListener("click", function() {
  if (theme.getAttribute("href") == "light-theme.css") {
    theme.href = "dark-theme.css";
  } else {
    theme.href = "light-theme.css";
  }
});