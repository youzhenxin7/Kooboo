import context from "../../context";
import { EditorShade } from "./EditorShade";

let editorShade: EditorShade;

export function registerEditorShade(document: Document) {
  if (editorShade) return;
  editorShade = new EditorShade(document);

  context.editableEvent.addEventListener(display => {
    if (!context.lastSelectedDomEventArgs) return;

    if (display) {
      editorShade.updateSource(context.lastSelectedDomEventArgs.element);
    } else {
      editorShade.clear();
    }
  });

  context.tinymceInputEvent.addEventListener(() => {
    if (!context.lastSelectedDomEventArgs) return;
    editorShade.updateSource(context.lastSelectedDomEventArgs.element);
  });
}
