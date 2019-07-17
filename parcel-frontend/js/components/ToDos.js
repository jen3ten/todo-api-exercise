import imgTodo from "~/img/img_todo.jpg";

export default function ToDo(todos) {
  return `
        <img src=${imgTodo}>
        <ol>
            ${todos
              .map(todo => {
                return `
                <li>
                    <h3>${todo.item}</h3>
                    ${todo.tag.map(tagitem => {
                      return `
                            <h4>${tagitem.name}</h4>
                        `;
                    })}
                </li>
                `;
              })
              .join("")}
        </ol>

        <section class="add-todo">
            <input class="add-todo__todoname" type="text" placeholder="Add a todo!">
            <button class="add-todo__submit">Submit</button>
        </section>
    `;
}
