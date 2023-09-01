var cardTemplate = function (str) {
  var html = "<div>";
  html += '<div class="card-body">';
  html += str;
  html += "</div>";
  html += "</div>";

  return html;
};

$(document).on("click", "[event='formPopup']", function () {
  $.ajax({
    type: "POST",
    url: "/home/modal",
    data: {},
    contentType: "application/json; charset=utf-8",
    dataType: "html",
    success: function (result) {
      bootbox.dialog({
        title: "Add new contact",
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

function toggleColumnSize() {
  let columnDiv = document.getElementById("columnContainer");
  let sideInfo = document.getElementById("sideInfo");
  if (columnDiv.classList.contains("col-md-11")) {
    columnDiv.classList.remove("col-md-11");
    columnDiv.classList.add("col-md-5");
    sideInfo.classList.remove("d-none");
  } else if (columnDiv.classList.contains("col-md-5")) {
    columnDiv.classList.remove("col-md-5");
    columnDiv.classList.add("col-md-11");
    sideInfo.classList.add("d-none");
  }
}

/* $(function () {
  $('[data-toggle="tooltip"]').tooltip();
}); */
