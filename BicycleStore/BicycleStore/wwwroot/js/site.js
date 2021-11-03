// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

let page = 1

$('#bicycle-list').load('/Home/BicycleList')

$('#search').on('click', function () {
    console.log(1);
    let searchText = $('#searchText').val()
    let companyText = $('#companySelect').val()
    let wheelDiameterText = $('#wheelDiameterSelect').val()
    let frameMaterialText = $('#frameMaterialSelect').val()
    let brakeTypeText = $('#brakeTypeSelect').val()
    let colorText = $('#colorSelect').val()
    $('#bicycle-list').load(`/Home/BicycleList/?search=${searchText}&company=${companyText}&wheelDiameter=${wheelDiameterText}&frameMaterial=${frameMaterialText}&brakeType=${brakeTypeText}&color=${colorText}`)
})

$('.pageSelector').on('click',function () {
    let searchText = $('#searchText').val()
    let companyText = $('#companySelect').val()
    let wheelDiameterText = $('#wheelDiameterSelect').val()
    let frameMaterialText = $('#frameMaterialSelect').val()
    let brakeTypeText = $('#brakeTypeSelect').val()
    let colorText = $('#colorSelect').val()
    
    if ($(this).val() == "inc") {
        console.log($('#availiablePages').val())
        if (page != $('#availiablePages').val()) {
            page++
        }
    }
    else if ($(this).val() == "dec") {
        if (page > 1) {
            page--
        }
    }
    else {
        page = $(this).val()
    }
    
    $('#bicycle-list').load(`/Home/BicycleList/?page=${page}&search=${searchText}&company=${companyText}&wheelDiameter=${wheelDiameterText}&frameMaterial=${frameMaterialText}&brakeType=${brakeTypeText}&color=${colorText}`)
})

