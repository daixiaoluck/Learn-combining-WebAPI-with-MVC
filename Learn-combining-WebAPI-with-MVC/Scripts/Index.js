$j_going = $(".j-going")

$j_going.click(function (event) {
    let $this = $(this)
    $.ajax({
        url: "http://localhost:1790/api/Attendances",
        method: "post",
        data: { gigId: $this.data("gigId") },
        success: function (response, statusText, xhr) {
            $this.removeClass("btn-default")
                .prop("disabled",true)
                .addClass("btn-info")
                .text("Going")
        },
        error: function (xhr, statusText, exception) {
            alert(xhr.responseJSON.Message)
        }
    })
})