import http from "./http.js";
import getAccountInfo from "./account.js";

getAccountInfo();
const urlParams = new URLSearchParams(window.location.search);
const artworkId = urlParams.get("artworkId");
const loadArtwork = async () => {
  console.log(artworkId);
  const artworkData = await http.send(
    "GET",
    `/api/v2/artworks/view/${artworkId}`
  );
  const artwork = JSON.parse(artworkData);
  const artworkImage = await http.send(
    "GET",
    `/api/v1/image/${artwork.artworkImage}`
  );
  const ownerData = await http.send("GET", `/api/v4/user/${artwork.ownerId}`);
  const owner = JSON.parse(ownerData);
  document.querySelector("#artwork-img").src = artworkImage;
  document.querySelector(
    ".author-name"
  ).innerHTML = `${owner.firstName} ${owner.lastName}`;
  document.querySelector("#description").innerHTML += artwork.description;
  document.querySelector(".publishdate").innerHTML = new Date(
    artwork.releasedDate
  );
};
///api/v2/artworks/view/comment/
const loadComments = async () => {
  const commentData = await http.send(
    "GET",
    `/api/v2/artworks/view/comment/${artworkId}`
  );
  const comments = JSON.parse(commentData);
  comments.forEach((comment) => {
    const commentBlock = document.createElement("div");
    commentBlock.classList.add("comment-block");
    commentBlock.innerHTML = `
      <a href="#" class="commenter-link">
        <div class="commenter-img img">
          <img src="./assets/images/user.png" alt="" />
        </div>
      </a>
      <p id="description">
        <a href="" class="commenter-name">${comment.commenter}</a>
        ${comment.comment}
      </p>
      <p class="comment-time">${comment.commentDate}</p>
    `;
    document.querySelector(".comment-holder").appendChild(commentBlock);
  });
};

loadComments();

loadArtwork();

/*
<div class="comment-block">
                <a href="#" class="commenter-link">
                  <div class="commenter-img img">
                    <img src="./assets/images/user.png" alt="" />
                  </div>
                </a>
                <p id="description">
                  <a href="" class="commenter-name">joliee</a>
                  Lorem ipsum dolor sit, amet consectetur adipisicing elit.
                  Corporis facilis culpa nisi earum suscipit eligendi magnam
                  saepe vel quas totam, dolor, veritatis odio dicta commodi
                  aliquam! Repudiandae odio alias nemo?
                </p>
                <p class="comment-time">28-11-2023</p>
              </div>
*/
