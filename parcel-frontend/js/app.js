import Header from "./components/header";
import Home from "./components/home";
import apiActions from "./api/api-actions";
import Value from "./components/Value";

pageBuild();

function pageBuild() {
  header();
  navHome();
  navValues();
}

function header() {
  const header = document.getElementById("header");
  header.innerHTML = Header();
}

function navHome() {
  const homeButton = document.querySelector(".nav__home");
  homeButton.addEventListener("click", function() {
    document.querySelector("#app").innerHTML = Home();
  });
}

function navValues() {
  const valuesButton = document.querySelector(".nav__values");
  valuesButton.addEventListener("click", function() {
    apiActions.getRequest("https://localhost:44326/api/values", values => {
      document.querySelector("#app").innerHTML = Value(values);
    });
  });
}
