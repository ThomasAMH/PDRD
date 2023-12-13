// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let prefixMap = {
    0: "Brother",
    1: "Sister",
    2: "Bishop",
    3: "Elder",
    4: "President",
};

// Create or remove Talk in Create View for Agendas Page

const btnAddTalk = document.getElementById("btn-add-talk");
const btnRemoveTalk = document.getElementById("btn-remove-talk");

if (btnAddTalk) {
    btnAddTalk.addEventListener("click", function () {
        const container = document.getElementById("talks-container");
        const newTalkRow = document.createElement("div");
        newTalkRow.className = "row-talk mb-2";
        newTalkRow.innerHTML = `
        <div class="d-flex justify-content-between align-items-center">
            <h5>Speaker</h5>
            <button type="button" class="btn btn-outline-primary" id="btn-remove-talk">X</button>
        </div>
        <div>
            <label name="Agenda.Talks[${container.children.length
            }].PersonID">Speaker Name</label>
            <select name="Agenda.Talks[${container.children.length
            }].PersonID" class="form-control" id="ConductingPersonSelect">
                <option value="" disabled>Member Name</option>
                ${avalaiblePeopleOptions.map(
                (option) =>
                    `<option value="${option.personID}">${prefixMap[option.personPrefix]
                    } ${option.firstName} ${option.lastName}</option>`
            )}
            </select>
        </div>
        <div class="form-group mb-3">
            <label name="Agenda.Talks[${container.children.length
            }].Topic" class="control-label"></label>
            <input name="Agenda.Talks[${container.children.length
            }].Topic" class="form-control" />
        </div>
        `;
        container.appendChild(newTalkRow);
        const btnRemoveTalk = newTalkRow.querySelector("#btn-remove-talk");
        btnRemoveTalk.addEventListener("click", function () {
            this.parentNode.parentNode.remove();
        });
    });
}

if (btnRemoveTalk) {
    btnRemoveTalk.addEventListener("click", function () {
        this.parentNode.parentNode.remove();
    });
}

// Create or remove Talk in Edit View for Agendas Page
