import http from "./http.js";
import getAccountInfo from "./account.js";

getAccountInfo();
let startIndex = 0;
let endIndex = 50;
const loadArtwork = async (startIndex, endIndex) => {
  const artworksData = await http.send("GET", "/api/v2/artworks/search/getAll");
  const artworks = JSON.parse(artworksData);
  const cardHolder = document.querySelector(".card-holder");

  const loadMoreArtwork = async () => {
    for (let i = startIndex; i < endIndex; i++) {
      const artwork = artworks[i];
      if (!artwork) return;

      const { artworkImage, ownerId } = artwork;
      const artworkImg = await http.send(
        "GET",
        `/api/v1/image/${artworkImage}`
      );
      const ownerData = await http.send("GET", `/api/v4/user/${ownerId}`);
      const owner = JSON.parse(ownerData);

      cardHolder.innerHTML += `
        <div class="card">
          <a href="artwork?artworkId=${artwork.artworkId}" class="product-block">
            <div class="card-img img">
              <img src="${artworkImg}" alt="" />
            </div>
            <div class="product-info">
              <button class="favor-btn" data-id="${artwork.artworkId}">
                <i class="bx bx-archive-in"></i>
                Favor
              </button>
              <p class="product-bottom">${artwork.name}</p>
            </div>
          </a>
          <div class="creator-block">
            <a href="#" class="creator-link">${owner.firstName} ${owner.lastName}</a>
            <div class="reaction">
              <i class="bx bxs-heart"></i>
              <p class="reaction-count">100</p>
            </div>
          </div>
        </div>
      `;
    }

    startIndex += 50;
    endIndex += 50;
  };

  loadMoreArtwork();
};

loadArtwork(startIndex, endIndex);
window.addEventListener("scroll", () => {
  console.log(window.innerHeight + window.scrollY, document.body.offsetHeight);
  if (window.innerHeight + window.scrollY >= document.body.offsetHeight) {
    loadArtwork(startIndex, endIndex);
  }
});
