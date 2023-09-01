$(document).on("click", "[event='profilePopup']", function (e) {
  e.preventDefault();
  console.log("profile popup");
  $.ajax({
    type: "POST",
    url: "/Customer/Popups/ProfilePopup/Index",
    data: {},
    contentType: "application/json; charset=utf-8",
    dataType: "html",
    success: function (result) {
      bootbox.dialog({
        title: "Assign admin",
        message: cardTemplate(result),
        size: "",
        buttons: {
          cancel: {
            label: "Kapat",
            className: "btn-danger",
            callback: function () {},
          },
          ok: {
            label: "Kaydet",
            className: "btn-info",
            callback: function () {
              /* basicDurum(url, id); */
            },
          },
        },
      });
    },
    error: function (errormessage) {
      alert(errormessage.responseText);
      console.log(errormessage);
    },
  });
});

console.log("çalışıyor");
/* url part of this function does not work. Here is the relative path of my Profilepopups.cshtml :CrmTemplate\Views\Customer\Popups\ProfilePopup.cshtml  */
