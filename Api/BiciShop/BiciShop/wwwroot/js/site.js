// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#biciListDiv').load('/Home/BiciList')

$('.asyncLoadBtn').click(function () {
    let searchText = $('#searchText').val()
    let colorSelect = $('#colorSelect').val()
    let typeSelect = $('#typeSelect').val()
    let sort = $('#sortTypeInp').val()

    if ($(this).hasClass('sortBtn')) {
        sort = $(this).val()
    }
    $('#biciListDiv').load(`/Home/BiciList/?searchText=${searchText}&color=${colorSelect}&biciType=${typeSelect}&sortType=${sort}`)
})