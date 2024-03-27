import http from "./http.js";
import getAccountInfo from "./account.js";

getAccountInfo();

const load = async () => {
  const data = await http.send("GET", "/api/v3/dashboard/admin");
  console.log(JSON.parse(data));

  const { artworks, orders, users } = JSON.parse(data);
  console.log(artworks, orders, users);
  const awDataBody = document.querySelector("#artwork-data-body");
  const userDataBody = document.querySelector("#user-data-body");
  const orderDataBody = document.querySelector("#order-data-body");
  users.forEach((item) => {
    userDataBody.innerHTML += `
        <tr>
            <td>${item.firstName} ${item.lastName}</td>
            <td>${item.email}</td>
            <td>${item.phone}</td>
            <td>
                ${item.address}
            </td>
            <td>01/01/2022</td>
            <td class="Online">Online</td>
            <td>
                <a href="#" class="edit-btn">
                    <i class="bx bx-pencil"></i>
                </a>
            </td>
            <td>
                <a href="#" class="remove-btn">
                    <i class="bx bx-eraser"></i>
                </a>
            </td>
        </tr>`;
  });
  artworks.slice(0, 50).forEach((item) => {
    awDataBody.innerHTML += `
    <tr>
    <td>${item.name}</td>
    <td>${item.ownerId}</td>
    <td>${item.cateId}</td>
    <td>
      ${item.description}
    </td>
    <td>${new Date(item.releasedDate)}</td>
    <td>100.0 $</td>
    <td class="Online">Public</td>
    <td>
      <a href="#" class="edit-btn">
        <i class="bx bx-pencil"></i>
      </a>
    </td>
    <td>
      <a href="#" class="remove-btn">
        <i class="bx bx-eraser"></i>
      </a>
    </td>
  </tr>
    `;
  });
  orders.forEach((item) => {
    orderDataBody.innerHTML += `
    <tr>
    <td>${item.orderId}</td>
    <td>${item.userId}</td>
    <td>${item.artworkId}</td>
    <td>${item.orderDate}</td>
    <td>${item.status}</td>
    </tr>
    `;
  });
};

load();
