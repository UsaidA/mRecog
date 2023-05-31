using mRecog.Application.TodoLists.Queries.ExportTodos;

namespace mRecog.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
