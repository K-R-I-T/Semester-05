import http from "./http.js";
import getAccountInfo from "./account.js";

getAccountInfo();

document.querySelector("#image").addEventListener("change", (event) => {
  const file = event.target.files[0];
  if (file) {
    const reader = new FileReader();
    reader.addEventListener("load", (event) => {
      document.querySelector("#imagePreview").src = event.target.result;
    });
    reader.readAsDataURL(file);
  }
});
document
  .querySelector("#publish-form")
  .addEventListener("submit", async (event) => {
    event.preventDefault();
    const formData = new FormData(event.target);
    const image = formData.get("image");
    const name = formData.get("name");
    const description = formData.get("description");
    const cateId = formData.get("cateogry");
    const price = formData.get("price");
    uploadImage(image)
      .then((imageId) => {
        const artwork = {
          artworkImage: imageId,
          name,
          description,
          cateId,
          price,
        };
        http.send("POST", "/api/v2/artworks/publish", artwork);
      })
      .then(() => {
        alert("Artwork published successfully");
      });
  });

const loadImage = async (image) => {
  try {
    if (image) {
      const reader = new FileReader();

      return new Promise((resolve, reject) => {
        reader.onload = (e) => {
          const imageDataUrl = e.target.result;

          try {
            resolve(imageDataUrl);
          } catch (error) {
            reject(error);
          }
        };

        reader.readAsDataURL(image);
      });
    }
  } catch (error) {
    throw error;
  }
};

const uploadImage = async (image) => {
  try {
    const imageData = await loadImage(image.files[0]);
    const imageId = await sendText(
      "POST",
      "http://localhost:8080/OnlyArts/api/v1/images",
      imageData
    );
    return imageId;
  } catch (error) {
    console.log(error);
  }
};
