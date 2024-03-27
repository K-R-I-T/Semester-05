import http from "./http.js";

const signupForm = document.querySelector("#signup-form");
const signupErrorMessage = document.querySelector("#signup-error-message");
signupForm.addEventListener("submit", async (event) => {
  event.preventDefault();

  try {
    const firstname = document.querySelector("#firstname").value;
    const lastname = document.querySelector("#lastname").value;
    const email = document.querySelector("#email").value;
    const password = document.querySelector("#password").value;
    const repassword = document.querySelector("#repassword").value;
    const role = document.querySelector("#myDropdown").value;
    if (password !== repassword) throw new Error("Password does not match");
    // Check if all fields are filled out
    if (
      !firstname ||
      !lastname ||
      !email ||
      !password ||
      !repassword ||
      !role
    ) {
      throw new Error("All fields are required");
    }
    //Check if Firstname and Lastname contain only letters
    const nameRegex = /^[a-zA-Z]+$/;
    if (!nameRegex.test(firstname) || !nameRegex.test(lastname)) {
      throw new Error("Firstname and Lastname should contain only letters");
    }
    const nameRegex2 = /[^A-Za-z0-9]+$/;
    if (nameRegex2.test(firstname) || nameRegex2.test(lastname)) {
      throw new Error(
        "Firstname and Lastname should not contain special characters"
      );
    }
    // Check if password matches
    if (password !== repassword) {
      throw new Error("Password does not match");
    }

    // Validate email format
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailRegex.test(email)) {
      throw new Error("Invalid email format");
    }

    // Validate password strength (for example, at least 8 characters)
    const passwordRegex = /^(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
    if (password.length < 8) {
      throw new Error("Password must be at least 8 characters long");
    } else if (!passwordRegex.test(password)) {
      throw new Error(
        "Password should contain both uppercase and lowercase letters"
      );
    }

    const data = {
      firstName: `${firstname}`,
      lastName: `${lastname}`,
      email: `${email}`,
      password: `${password}`,
      roleId: `${role}`,
    };
    const token = await http.send(
      "POST",
      "/api/v1/authentication/register",
      data
    );
    console.log(token);
    localStorage.setItem("authtoken", `${token}`);
    console.log("User registered successfully");
    alert("User registered successfully");
    window.location.href = "http://localhost:8080/OnlyArts/index.html";
  } catch (error) {
    error = error.toString().replace("Error: ", "");
    console.log(error);
    signupErrorMessage.innerHTML = `${error}`;
  }
});
