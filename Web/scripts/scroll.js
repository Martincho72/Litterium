  document.addEventListener("DOMContentLoaded", function() {
    var links = document.querySelectorAll('a[href^="#"]');
    
    links.forEach(function(link) {
      link.addEventListener("click", function(e) {
        e.preventDefault();
        
        var targetId = this.getAttribute("href");
        var targetElement = document.querySelector(targetId);
        
        if (targetElement) {
          var offset = 6 * parseFloat(getComputedStyle(document.documentElement).fontSize);
          var targetPosition = targetElement.offsetTop - offset;
          
          window.scrollTo({
            top: targetPosition,
            behavior: "smooth"
          });
        }
      });
    });
  });
