import http from "./http.js";
import getAccountInfo from "./account.js";

getAccountInfo();

const load = async () => {
  const urlParams = new URLSearchParams(window.location.search);
  const userId = urlParams.get("userId");
  let user;
  if (!userId) {
    const userData = await http.send("GET", "/api/v1/authentication/account");
    user = JSON.parse(userData);
  } else {
    const userData = await http.send("GET", `/api/v4/user/${userId}`);
    user = JSON.parse(userData);
  }
  console.log(user);
};
