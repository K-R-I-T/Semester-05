import http from "./http.js";

const loginForm = document.querySelector(".login-form");
const loginErrorMessage = document.querySelector("#login-error-message");

loginForm.addEventListener("submit", async (event) => {
  event.preventDefault();
  const formData = new FormData(loginForm);
  const email = formData.get("email");
  const password = formData.get("password");
  
  const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  const passwordRegex = /^(?=.*[a-z])(?=.*[A-Z]).{8,}$/; // matches only alphanumeric characters
  //Validate email and password
  if (!email) {
    loginErrorMessage.textContent = "Email is required";
    return;
  } else if (!emailRegex.test(email)) {
    loginErrorMessage.textContent = "Invalid email format";
    return;
  }
  if (!password) {
    loginErrorMessage.textContent = "Password is required";
    return;
  } else if (!passwordRegex.test(password)) {
    loginErrorMessage.textContent =
      "Password should be at least 8 characters long and contain both uppercase and lowercase letters";
    return;
  }

  try {
    const data = await http.send("POST", `/api/v1/authentication/login`, {
      email,
      password,
    });
    localStorage.setItem("authtoken", data);
    window.location.href = "home";
  } catch (error) {
    loginErrorMessage.textContent = error.message;
  }
});
