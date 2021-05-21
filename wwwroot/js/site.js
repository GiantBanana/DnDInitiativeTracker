// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var updateInitiative = function(element){
    var newInitiative = element.innerHTML;
    var creatureName = element.parentNode.getElementsByTagName("th")[0].innerHTML; 
    console.log(creatureName);
}

