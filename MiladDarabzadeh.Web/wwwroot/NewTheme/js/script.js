jQuery(document).ready(function () { let e = $(window); $(window).on("resize", function () { e.width() >= 1200 && $(".dropdown").hover(function () { $(".dropdown-menu", this).not(".in .dropdown-menu").stop(!0, !0).slideDown("400"), $(this).toggleClass("show") }, function () { $(".dropdown-menu", this).not(".in .dropdown-menu").stop(!0, !0).slideUp("400"), $(this).toggleClass("show") }) }), e.width() >= 1200 && $(".dropdown").hover(function () { $(".dropdown-menu", this).not(".in .dropdown-menu").stop(!0, !0).slideDown("400"), $(this).toggleClass("show") }, function () { $(".dropdown-menu", this).not(".in .dropdown-menu").stop(!0, !0).slideUp("400"), $(this).toggleClass("show") }), $(window).scroll(function () { $(this).scrollTop() > 100 ? $("#scroll").fadeIn() : $("#scroll").fadeOut() }), $("#scroll").click(function () { return $("html, body").animate({ scrollTop: 0 }, 600), !1 }); var s = $(".grid").isotope({ percentPosition: !0, itemSelector: ".portfolio-headmove", isOriginLeft: !1 }); $(".portfolio-filter").on("click", "a", function (e) { e.preventDefault(), $(this).parent().addClass("active").siblings().removeClass("active"); var o = $(this).attr("data-filter"); s.isotope({ filter: o }) }), $(".portfolio-filter ul li a").on("click", function () { $(".portfolio-filter ul li a").removeClass("current"), $(this).addClass("current") }); let o = $(window); $(window).on("resize", function () { o.width() >= 768 ? ($("#collapsesearch").addClass("show"), $("#collapseFavorite").addClass("show")) : ($("#collapsesearch").removeClass("show"), $("#collapseFavorite").removeClass("show")) }), o.width() >= 768 ? ($("#collapsesearch").addClass("show"), $("#collapseFavorite").addClass("show")) : ($("#collapsesearch").removeClass("show"), $("#collapseFavorite").removeClass("show")); var i = $('<div id="log"></div>'); $("body").append(i), $('[type*="radio"]').change(function () { var e = $(this); i.html(e.attr("value")) }) }); const swiper1 = new Swiper(".swiper-1", { direction: "horizontal", loop: !0, grabCursor: !0, autoplay: { delay: 4e3 } }), swiper2 = new Swiper(".swiper-2", { slidesPerView: 4, spaceBetween: 30, loop: !0, grabCursor: !0, breakpoints: { 0: { slidesPerView: 1 }, 500: { slidesPerView: 1.5 }, 768: { slidesPerView: 2 }, 992: { slidesPerView: 3 }, 1200: { slidesPerView: 4 } } }), swiper3 = new Swiper(".swiper-3", { slidesPerView: 3, spaceBetween: 15, loop: !0, grabCursor: !0, autoplay: { delay: 4e3 }, breakpoints: { 0: { slidesPerView: 1 }, 420: { slidesPerView: 1.3 }, 768: { slidesPerView: 1.8 }, 992: { slidesPerView: 2 }, 1200: { slidesPerView: 3 } } }), swiper4 = new Swiper(".swiper-4", { slidesPerView: 3, spaceBetween: 30, loop: !0, grabCursor: !0, centeredSlides: !0, breakpoints: { 0: { slidesPerView: 1 }, 420: { slidesPerView: 1.3 }, 768: { slidesPerView: 1.8 }, 992: { slidesPerView: 2 }, 1200: { slidesPerView: 3 } } });