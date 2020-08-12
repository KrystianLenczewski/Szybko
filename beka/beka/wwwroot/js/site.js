// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
var ListOfQuestion = [];
// Write your JavaScript code.
$(document).ready(function () {
    var employee = [];
    var testId;

    employee.Name = $('#nameTest').val();
    $("#addTest").click(function () {
        $.ajax(
            {
                type: "POST", //HTTP POST Method  
                url: "Test/Create", // Controller/View   
                dataType:"json",
                data: { //Passing data  
                    Name: $("#txtName").val() //Reading text box values using Jquery   

                },
                success: function (data) {
                    testId = data.Id;
                    $.ajax(
                        {
                            type: "GET",
                            dataType:"json",
                            url: "Test/GetTestById/" + data.Id,
                            success: function (response) {
                               
                                $("#ziomek").append(response.Name);
                            },
                        }

                       
                        )

                }

            });
    })

    $("#addQuestion").click(function () {
        $.ajax(
            {
                type: "POST", //HTTP POST Method  
                url: "Question/Create/" + testId, // Controller/View   
                dataType: "json",
                data: { //Passing data  
                    Name: $("#questionName").val() //Reading text box values using Jquery   

                },
                success: function (response) {
                    $("#pytanieTest").append(response.Name);
                }
            

            })


    })

})